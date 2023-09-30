using BTVN_1.Model;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace BTVN_1
{
    public partial class Form1 : Form
    {
        public ghengoiEntities1 context = new ghengoiEntities1();
        private int ButtonWidth = 40;
        private int ButtonHeight = 40;
        private int dong = 10;
        private int cot = 13;
        private double TongTien = 0;
        int h = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var table = context.Table_1.ToList();
            int sodong = 5;
            int socot = 5;
            int dem = 0;

            for (int row = 0; row < dong; row++)
            {
                for (int col = 0; col < cot; col++)
                {
                    Button button = new Button();
                    button.Name = "button" + dem;
                    button.Width = ButtonWidth;
                    button.Height = ButtonHeight;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 2;
                    
                    int x = 700 - (col * (ButtonWidth + socot));
                    int y = 75 + row * (ButtonHeight + sodong);

                    if (table[dem].LoaiGhe == "S")
                    {
                        cot = 15;
                        x = 745 - (col * (ButtonWidth + socot));
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

                    button.BackColor = table[dem].TrangThai == 1 ? Color.Yellow : (table[dem].LoaiGhe == "S" ? Color.DeepPink : Color.White);
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
            try
            {
                if(clickedButton.BackColor == Color.Yellow)
                {
                    throw new Exception("Ghế đã có người đặt");
                }
                for (int i = 0; i < table.Count; i++)
                {
                    if (clickedButton.Text == table[i].TenGhe)
                    {
                        if (clickedButton.BackColor == Color.Red)
                        {
                            clickedButton.BackColor = table[i].LoaiGhe == "S" ? Color.DeepPink : Color.White;
                            TongTien -= table[i].LoaiGhe == "S" ? table2[2].DonGia : (table[i].LoaiGhe == "T" ? table2[0].DonGia : table2[1].DonGia);
                            --h;
                        }
                        else
                        {
                            clickedButton.BackColor = Color.Red;
                            TongTien += table[i].LoaiGhe == "S" ? table2[2].DonGia : (table[i].LoaiGhe == "T" ? table2[0].DonGia : table2[1].DonGia);
                            ++h;
                        }
                    }
                }
                    buttonthanhtoan.Enabled = h>0 ? true : false;
                textBoxthanhtien.Text = TongTien.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            h = 0;
            buttonthanhtoan.Enabled=false;
            var table = context.Table_1.ToList();
            Form2 form2 = new Form2();
            string t = "";
            for (int i=0; i<table.Count; i++)
            {
                Button button = Controls.Find("button" + (i), true).FirstOrDefault() as Button;
                if (button.BackColor == Color.Red)
                {
                    table[i].TrangThai = 1;
                    t += button.Text;
                }
            }
            form2.textBoxghedadat.Text = t;
            form2.textBoxthanhtien.Text = textBoxthanhtien.Text;
            context.SaveChanges();
            form2.ShowDialog();
            if(form2.check == true)
            {
                textBoxthanhtien.Text = "0";
                chancecolor();
            }
            else
            {
                buttonthanhtoan.Enabled = true;
            }
        }

        private void buttonclean_Click(object sender, EventArgs e)
        {
            h = 0;
            buttonthanhtoan.Enabled = false;
            var table = context.Table_1.ToList();
            var table3 = context.Table_3;
            table3.RemoveRange(table3);
            textBoxthanhtien.Text = "";
            for (int i = 0; i < table.Count; i++)
            {
                Button button = Controls.Find("button" + (i), true).FirstOrDefault() as Button;
                table[i].TrangThai = null;
                if (button.BackColor == Color.Yellow || button.BackColor == Color.Red)
                {
                    button.BackColor = table[i].LoaiGhe == "S" ? button.BackColor = Color.DeepPink : button.BackColor = Color.White;
                }
            }
            context.SaveChanges();
        }
        public void chancecolor()
        {
            var table = context.Table_1.ToList();
            for(int i = 0; i < table.Count; i++)
            {
                Button button = Controls.Find("button" + (i), true).FirstOrDefault() as Button;
                if (button.BackColor == Color.Red)
                {
                    button.BackColor = Color.Yellow;
                }
            }
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
