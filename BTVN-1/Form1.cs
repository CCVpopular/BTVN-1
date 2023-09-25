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
        private ghengoiEntities1 context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new ghengoiEntities1();
            var table = context.Table_1.ToList();
            int Buindex = 0;
            foreach (var item in table)
            {
                VBButton button = Controls.Find("vbButton" + (Buindex + 1), true)[0] as VBButton;
                if (button != null)
                {
                    button.Text = item.TenGhe;
                    Buindex++;
                }
                if (item.TrangThai == 1)
                {
                    if (button.Text == item.TenGhe)
                    {
                        button.BackColor = Color.Gray;
                    }
                }
                else
                {
                    if (button.Text == item.TenGhe)
                    {
                        if(item.LoaiGhe == "S")
                        {
                            button.BackColor = Color.Coral;
                        }
                        else
                        {
                            button.BackColor = Color.White;
                        }
                    }
                }                
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            VBButton Cbutton = (VBButton)sender;
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
                            Cbutton.BackColor = Color.Coral; 
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
