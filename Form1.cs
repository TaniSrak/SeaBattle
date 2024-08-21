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
            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(row);
            }
           
        }

        Model model;

        string[] row = { "", "", "", "", "", "", "", "", "", "" };
        int x4 = 1;
        int x3 = 2;
        int x2 = 3;
        int x1 = 4;

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
            //for (int x = 0; x < 10; x++)
            //{
            //    for (int y = 0; y < 10; y++)
            //    {
            //        string name = "b" + x.ToString() + y.ToString();
            //        var b = this.Controls.Find(name, true);

            //        if (b.Count() > 0)
            //        {
            //            var btn = b[0];
            //            switch (model.PlayerShips[x, y])
            //            {
            //                case CoordStatus.Ship:
            //                    btn.Text = "x"; //рисуем х, на месте где корабль
            //                    break;
            //                case CoordStatus.None: btn.Text = ""; break;

            //            }
            //        }
            //    }
            //}

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    switch (model.PlayerShips[x, y])
                    {
                        case CoordStatus.Ship:
                            dataGridView1[x, y].Value = "x"; //рисуем х, на месте где корабль
                            break;
                        case CoordStatus.None:
                            dataGridView1[x, y].Value = ""; break;

                    }
                }
            }

        }

        private void button63_Click(object sender, EventArgs e) //поставить
        {
            int cnt = dataGridView1.SelectedCells.Count;
            if (cnt > 0)
            {
                if (checkBox2.Checked) //если ячейка пустая
                {
                    int a, b;
                    a = dataGridView1.SelectedCells[0].RowIndex;
                    b = dataGridView1.SelectedCells[0].ColumnIndex;
                    if (dataGridView1.Rows[a].Cells[b].Value.ToString() == "") { return; }
                }

                if (cnt == 1)
                {
                    if (!checkBox2.Checked) 
                    { 
                        if (x1 == 0) return;
                        x1--;
                    }
                    else { x1++; }
                }
                if (cnt == 2)
                {
                    if (!checkBox2.Checked)
                    {
                        if (x2 == 0) return;
                        x2--;
                    }
                    else { x2++; }
                }
                if (cnt == 3)
                {
                    if (!checkBox2.Checked)
                    {
                        if (x3 == 0) return;
                        x3--;
                    }
                    else { x3++; }
                }
                if (cnt == 4)
                {
                    if (!checkBox2.Checked)
                    {
                        if (x4 == 0) return;
                        x4--;
                    }
                    else { x4++; }
                }
                if(x1 < 0 || x2 < 0 || x3 < 0 || x4 < 0)
                {
                    return;
                }

                for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                {
                    int x = dataGridView1.SelectedCells[i].ColumnIndex;
                    int y = dataGridView1.SelectedCells[i].RowIndex;
                    CoordStatus coordStatus;
                    if (!checkBox2.Checked)
                    {
                        coordStatus = CoordStatus.Ship;
                    }
                    else
                    {
                        coordStatus = CoordStatus.None;
                    }
                    model.PlayerShips[x, y] = coordStatus;
                }
                dataGridView1.ClearSelection();
            }
            button64_Click(sender, e);
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = dataGridView1.SelectedCells[0].ColumnIndex;
            int y = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = x.ToString() + y.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e) //смена функционала у кнопки
        {
            if (checkBox2.Checked)
            {
                button63.Text = "Удалить";
            }
            else
            {
                button63.Text = "Поставить";
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int cnt = dataGridView1.SelectedCells.Count;
            textBox1.Text = cnt.ToString();
            if (cnt > 4 )
            {
                MessageBox.Show("Превышено количество клеток!");
                int x = dataGridView1.SelectedCells[cnt - 1].ColumnIndex;
                int y = dataGridView1.SelectedCells[cnt - 1].RowIndex;
                dataGridView1.Rows[y].Cells[x].Selected = false;
                dataGridView1.ClearSelection();
            }
            
        }
    }
}
