using BTVN_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_1
{
    public partial class Form2 : Form
    {
        static ghengoiEntities1 context = new ghengoiEntities1();
        static Form1 form1 = new Form1();
        static List<Table_3> table3s = context.Table_3.ToList();
        public bool check = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonthem_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxtenkhach.Text == "")
                {
                    throw new Exception("Vui lòng nhập tên khách hàng");
                }
                var table_3 = new Table_3();
                table_3.TenKhachHang = textBoxtenkhach.Text;
                table_3.GheDaDat = textBoxghedadat.Text;
                table_3.ThanhTien = double.Parse(textBoxthanhtien.Text);
                context.Table_3.Add(table_3);
                context.SaveChanges();
                check = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
