namespace SeaBattle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.PlayerShips[0, 0] = CoordStatus.Ship;
            model.PlayerShips[5, 2] = CoordStatus.Ship;
            model.PlayerShips[5, 3] = CoordStatus.Ship;
            model.PlayerShips[5, 4] = CoordStatus.Ship;
            model.PlayerShips[5, 5] = CoordStatus.Ship;
        }

        Model model;

        private void button1_Click(object sender, EventArgs e)
        {
            model.LastShot = model.Shot(textBox1.Text);
            int x = int.Parse(textBox1.Text.Substring(0, 1));
            int y = int.Parse(textBox1.Text.Substring(1));
            switch (model.LastShot)
            {
                case ShotStatus.Miss:
                    model.EnemyShips[x, y] = CoordStatus.None; break;
                case ShotStatus.Wounded:
                    model.EnemyShips[x, y] = CoordStatus.Got; break;
                case ShotStatus.Kill:
                    model.EnemyShips[x, y] = CoordStatus.Got; break;

            }

            if (model.LastShot == ShotStatus.Wounded)
            {
                model.LastShotCoord = textBox1.Text;
                model.WoundedStatus = true;
            }
            MessageBox.Show(model.LastShot.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s;
            int x, y;
            do
            {
                s = model.ShotGen();
                x = int.Parse(s.Substring(0, 1));
                y = int.Parse(s.Substring(1));
            }
            while (model.EnemyShips[x, y] != CoordStatus.None);
            textBox1.Text = s;
        }

        private void button64_Click(object sender, EventArgs e) //перерисовать
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    string name = "b" + x.ToString() + y.ToString();
                    var b = this.Controls.Find(name, true);

                    if (b.Count() > 0)
                    {
                        var btn = b[0];
                        switch (model.PlayerShips[x, y])
                        {
                            case CoordStatus.Ship:
                                btn.Text = "x"; //рисуем х, на месте где корабль
                                break;
                            case CoordStatus.None: btn.Text = ""; break;

                        }
                    }
                }
            }
        }

        private void button63_Click(object sender, EventArgs e) //поставить
        {
            Direction direction;
            ShipType shipType = ShipType.x1;

            if(checkBox1.Checked)
            {
                direction = Direction.Vertical;
            }
            else
            {
                direction = Direction.Horizontal;
            }

            if (radioButton1.Checked)
            {
                shipType = ShipType.x1;
            }
            if (radioButton2.Checked)
            {
                shipType = ShipType.x2;
            }
            if (radioButton3.Checked)
            {
                shipType = ShipType.x3;
            }
            if (radioButton4.Checked)
            {
                shipType = ShipType.x4;
            }

            model.AddDelShip(textBox1.Text, shipType, direction, checkBox2.Checked);
            button64_Click(sender, e);
        }
    }
}
