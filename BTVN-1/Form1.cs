using BTVN_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_1
{
    public partial class Form1 : Form
    {
        private ghengoiEntities1 context= new ghengoiEntities1 ();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var table = context.Table_1.ToList ();
            int dorong = 40;
            int docao = 40;
            int sohang = 10;
            int socot = 13;
            int dem = 0;
            for (int row = 0; row < sohang; row++)
            {
                for (int col = 0; col < socot; col++)
                {
                    Button button = new Button();
                    button.Width = dorong;
                    button.Height = docao;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 2;
                    if (table[dem].LoaiGhe != "S")
                    {
                        button.Location = new Point(800 - (col * (dorong + 5)), 75 + row * (docao + 5));
                    }
                    else
                    {
                        socot = 15;
                        button.Location = new Point(845 - (col * (dorong + 5)), 75 + row * (docao + 5));
                        button.FlatAppearance.BorderColor = Color.DeepPink;                    
                    }
                    button.Text = $"{table[dem].TenGhe}";
                    if (table[dem].LoaiGhe == "T")
                    {
                        button.FlatAppearance.BorderColor = Color.LightGreen;
                        button.BackColor = Color.DeepPink;
                    }
                    if (table[dem].LoaiGhe == "V")
                    {
                        button.FlatAppearance.BorderColor = Color.LightCoral;
                    }
                    if (table[dem].TrangThai == 1)
                    {
                        button.BackColor = Color.Gray;
                    }
                    else
                    {
                        if (table[dem].LoaiGhe == "S")
                        {
                            button.BackColor= Color.DeepPink;
                        }
                        else
                        {
                            button.BackColor = Color.White;
                        }
                    }
                    button.Click += Button1_Click;
                    dem++;
                    this.Controls.Add(button);
                    
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Button Cbutton = (Button)sender;
            context = new ghengoiEntities1();
            var table = context.Table_1.ToList();
            foreach (var item in table)
            {
                if (item.TrangThai == null)
                {                    
                    if (Cbutton.Text == item.TenGhe)
                    {
                        Cbutton.BackColor = Color.Gray;
                        item.TrangThai = 1;
                    }                    
                }
                else 
                {         
                    if (Cbutton.Text == item.TenGhe)
                    {
                        if(item.LoaiGhe == "S")
                        {
                            Cbutton.BackColor = Color.DeepPink; 
                        }
                        else
                        {
                            Cbutton.BackColor = Color.White;
                        }
                        item.TrangThai = null;
                    }                   
                }
            }
            context.SaveChanges();
        }
    }
}
