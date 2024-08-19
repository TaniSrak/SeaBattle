using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle
{
    //Статус выстрела
    public enum ShotStatus 
    {
        Miss, //Промазал
        Wounded, //Ранил
        Kill, //Убил
        EndBattle //Конец боя
    }

    //Статус координат
    public enum CoordStatus 
    {
        None, //пусто
        Ship, //корабль
        Shot, //выстрел
        Got //попал
    }

    //Типы кораблей
    public enum ShipType { x4, x3, x2, x1 }

    // Направление кораблей
    public enum Direction 
    {
        Horizontal, Vertical
    }

    public class Model
    {
        public CoordStatus[,] PlayerShips = new CoordStatus[10, 10]; //массив координат своих кораблей (кораблей игрока)
        public CoordStatus[,] EnemyShips = new CoordStatus[10, 10]; //Количество клеток кораблей противника
        public int UndiscoverCells = 20; //Количество клеток кораблей противника
        public ShotStatus LastShot; ///Поле статуса последнего выстрела
        public bool WoundedStatus; //Поле статус ранения
        public string LastShotCoord; //Поле координат последнего выстрела 
        public bool FirstGot; //Поле статус первого попадания
        //Конструктор для инициализации полей модели
        public Model() 
        {
            LastShot = ShotStatus.Miss; 
            WoundedStatus = false;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PlayerShips[i, j] = CoordStatus.None;
                    EnemyShips[i,j] = CoordStatus.None;
                }
            }
        }

        //Выстрел игрока.Входящий параметр - координаты выстрела в виде строки из 2х цифр
        public ShotStatus Shot(string ShotCoord) 
        {
            ShotStatus result = ShotStatus.Miss;
            int x, y; //координаты выстрела в числовом виде
            x = int.Parse(ShotCoord.Substring(0, 1));
            y = int.Parse(ShotCoord.Substring(1));

            if (PlayerShips[x,y] == CoordStatus.None) //проверка статуса выстрела
            {
                result = ShotStatus.Miss;
            }
            else
            {
                result = ShotStatus.Kill;
                if((x != 9 && PlayerShips[x + 1, y] == CoordStatus.Ship) || 
                    (y != 9 && PlayerShips[x, y + 1] == CoordStatus.Ship) ||
                    (x != 0 && PlayerShips[x - 1, y] == CoordStatus.Ship) ||
                    (y != 0 && PlayerShips[x, y - 1] == CoordStatus.Ship) ||
                    (x < 8 && PlayerShips[x + 2, y] == CoordStatus.Ship) ||
                    (y < 8 && PlayerShips[x, y + 2] == CoordStatus.Ship) ||
                    (x > 1 && PlayerShips[x - 2, y] == CoordStatus.Ship) ||
                    (y > 1 && PlayerShips[x, y - 2] == CoordStatus.Ship) ||
                    (x < 7 && PlayerShips[x + 3, y] == CoordStatus.Ship) ||
                    (y < 7 && PlayerShips[x, y + 3] == CoordStatus.Ship) ||
                    (x < 2 && PlayerShips[x - 3, y] == CoordStatus.Ship) ||
                    (y > 2 && PlayerShips[x, y - 3] == CoordStatus.Ship))
                {
                    result = ShotStatus.Wounded;
                }
                PlayerShips[x, y] = CoordStatus.Got;
                UndiscoverCells--;

                if(UndiscoverCells == 0)
                {
                    result = ShotStatus.EndBattle;
                }
            }
            return result;
        }

        //Генерация выстрела
        public string ShotGen()
        {
            int x, y; //координаты выстрела в цифровом виде
            Random rand = new Random();

            //проверка статуса ранения
            if (LastShot == ShotStatus.Kill)
            {
                WoundedStatus = false; 
            }
            if ((LastShot != ShotStatus.Kill || LastShot == ShotStatus.Miss) && !WoundedStatus)
            {
                x = rand.Next(0, 9);
                y = rand.Next(0, 9);
            }
            else
            {
                x = int.Parse(LastShotCoord.Substring(0, 1));
                y = int.Parse(LastShotCoord.Substring(1));

                if (LastShot == ShotStatus.Wounded || FirstGot)
                {
                    FirstGot = true;
                    if (x != 9 && EnemyShips[x + 1, y] == CoordStatus.Ship) 
                    { 
                        x = x - 1;
                        FirstGot = false;
                    }
                    if (y != 9 && EnemyShips[x, y + 1] == CoordStatus.Ship) 
                    { 
                        x = y - 1;
                        FirstGot = false;
                    }
                    if (x != 0 && EnemyShips[x - 1, y] == CoordStatus.Ship) 
                    { 
                        x = x + 1;
                        FirstGot = false;
                    }
                    if (y != 0 && EnemyShips[x, y - 1] == CoordStatus.Ship) 
                    { 
                        x = y + 1;
                        FirstGot = false;
                    }
                    if (FirstGot)
                    {
                        int q = rand.Next(1, 4);
                        switch (q)
                        {
                            case 1: x++; break;
                            case 2: x--; break;
                            case 3: y++; break;
                            case 4: y--; break;
                        }
                    }
                }
                if (LastShot == ShotStatus.Miss && WoundedStatus)
                {
                    if (x < 8 && EnemyShips[x + 2, y] == CoordStatus.Got) x = x + 3;
                    else
                    if (y < 8 && EnemyShips[x, y + 2] == CoordStatus.Got) y = y + 3;
                    else
                    if (x > 1 && EnemyShips[x - 2, y] == CoordStatus.Got) x = x - 3;
                    else
                    if (y > 1 && EnemyShips[x, y - 2] == CoordStatus.Got) y = y - 3;
                    else
                    if (x < 7 && EnemyShips[x + 3, y] == CoordStatus.Got) x = x + 4;
                    else
                    if (y < 7 && EnemyShips[x, y + 3] == CoordStatus.Got) y = y + 4;
                    else
                    if (x > 2 && EnemyShips[x - 3, y] == CoordStatus.Got) x = x - 4;
                    else
                    if (y > 2 && EnemyShips[x, y - 3] == CoordStatus.Got) y = y - 4;
                    else
                    if (x < 9 && EnemyShips[x + 1, y] == CoordStatus.Got) x = x + 2;
                    else
                    if (y < 9 && EnemyShips[x, y + 1] == CoordStatus.Got) y = y + 2;
                    else
                    if (x > 0 && EnemyShips[x - 1, y] == CoordStatus.Got) x = x - 2;
                    else
                    if (y > 0 && EnemyShips[x, y - 1] == CoordStatus.Got) y = y - 2;
                }
            }
            

            string result = x.ToString() + y.ToString();
            return result;
        }

        //Проверка координат корабля (заглушка)
        public bool CheckCoord(string xy, ShipType Type, Direction direction = Direction.Vertical)
        {
            bool result = true;
            return result;
        }

        //метод заполнения корабля вручную и удаления корабля
        //xy - координаты корабля, Туре - тип корабля, direction - направление размещения корабля, deleting - добавить или удалить корабль
        //В случае успешной операции возвращает true
        public bool AddDelShip(string xy, ShipType Type, Direction direction = Direction.Vertical, bool deleting = false)
        {
            bool result = true;
            if(deleting || CheckCoord(xy, Type, direction))
            {
                int x, y;
                x = int.Parse(xy.Substring(0, 1));
                y = int.Parse(xy.Substring(1));
                CoordStatus status = new CoordStatus();
                if(deleting)
                {
                    status = CoordStatus.None;
                }
                else
                {
                    status = CoordStatus.Ship;
                }

                PlayerShips[x, y] = CoordStatus.Ship;

                if (direction == Direction.Vertical)
                {
                    switch (Type)
                    {
                        case ShipType.x2:
                            PlayerShips[x, y + 1] = status; break;
                        case ShipType.x3:
                            PlayerShips[x, y + 1] = status;
                            PlayerShips[x, y + 2] = status; break;
                        case ShipType.x4:
                            PlayerShips[x, y + 1] = status;
                            PlayerShips[x, y + 2] = status;
                            PlayerShips[x, y + 3] = status; break;
                    }
                }
                else
                {
                    switch (Type) //либо вниз, либо вправо
                    {
                        case ShipType.x2:
                            PlayerShips[x + 1, y] = status; break;
                        case ShipType.x3:
                            PlayerShips[x + 1, y] = status;
                            PlayerShips[x + 2, y] = status; break;
                        case ShipType.x4:
                            PlayerShips[x + 1, y] = status;
                            PlayerShips[x + 2, y] = status;
                            PlayerShips[x + 3, y] = status; break;
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }
        
        //Метод очистки всех кораблей
        public void DelShips()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    PlayerShips[i, j] = CoordStatus.None;
                }
            }
        }
       
        
    }
}
