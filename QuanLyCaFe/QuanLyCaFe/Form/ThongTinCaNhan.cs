using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class ThongTinCaNhan : Form
    {
        public int id { get; set; }
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public ThongTinCaNhan(int idget)
        {
            id = idget;
            InitializeComponent();
            hienthithongtin(idget);
        }
        public void hienthithongtin(int i)
        {
            tendangnhaptxt.Text = i.ToString();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            hienthithongtin(id);
        }
    }
}
