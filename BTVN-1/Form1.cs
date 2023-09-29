using BTVN_1.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BTVN_1
{
    public partial class Form1 : Form
    {
        private ghengoiEntities1 context = new ghengoiEntities1();
        private int ButtonWidth = 40;
        private int ButtonHeight = 40;
        private int Rows = 10;
        private int Columns = 13;
        private double totalPrice = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var table = context.Table_1.ToList();
            int rowSpacing = 5;
            int columnSpacing = 5;
            int dem = 0;

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    Button button = new Button();
                    button.Width = ButtonWidth;
                    button.Height = ButtonHeight;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 2;

                    int x = 700 - (col * (ButtonWidth + columnSpacing));
                    int y = 75 + row * (ButtonHeight + rowSpacing);

                    if (table[dem].LoaiGhe == "S")
                    {
                        Columns = 15;
                        x = 745 - (col * (ButtonWidth + columnSpacing));
                        button.FlatAppearance.BorderColor = Color.DeepPink;
                    }

                    button.Location = new Point(x, y);
                    button.Text = table[dem].TenGhe;

                    if (table[dem].LoaiGhe == "T")
                    {
                        button.FlatAppearance.BorderColor = Color.LightGreen;
                    }
                    else if (table[dem].LoaiGhe == "V")
                    {
                        button.FlatAppearance.BorderColor = Color.LightCoral;
                    }

                    button.BackColor = table[dem].TrangThai == 1 ? Color.Red : (table[dem].LoaiGhe == "S" ? Color.DeepPink : Color.White);
                    button.Click += Button1_Click;
                    dem++;
                    this.Controls.Add(button);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            var table = context.Table_1.ToList();
            var table2 = context.Table_2.ToList();

            for (int i = 0; i < table.Count; i++)
            {
                if (clickedButton.Text == table[i].TenGhe)
                {
                    if (clickedButton.BackColor == Color.Red)
                    {
                        clickedButton.BackColor = table[i].LoaiGhe == "S" ? Color.DeepPink : Color.White;
                        totalPrice -= table[i].LoaiGhe == "S" ? table2[2].DonGia : (table[i].LoaiGhe == "T" ? table2[0].DonGia : table2[1].DonGia);
                    }
                    else
                    {
                        clickedButton.BackColor = Color.Red;
                        totalPrice += table[i].LoaiGhe == "S" ? table2[2].DonGia : (table[i].LoaiGhe == "T" ? table2[0].DonGia : table2[1].DonGia);
                    }
                }
            }

            textBoxthanhtien.Text = totalPrice.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
