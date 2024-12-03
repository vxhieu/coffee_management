using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaFe
{
    public partial class DanhMuc : Form
    {
        private string id;
        DataClasses1DataContext db = new DataClasses1DataContext();
        FoodCategory danhmuc = null;
        public DanhMuc(string id)
        {
            this.id = id;
            InitializeComponent();
            loadDm();
        }
        public void loadDm()
        {
            //Cập nhật
            if (!string.IsNullOrEmpty(id))
            {
                labelDM.Text = "Cập nhật danh mục";
                danhmuc = db.FoodCategories.FirstOrDefault(x => x.id == int.Parse(id));
                txtDanhMucDoUong.Text = danhmuc.ten;
            }
            else btnXoaDM.Hide();
        }

        private void btnLuuDanhMuc_Click(object sender, EventArgs e)
        {
            //nếu cập nhật
            if (danhmuc != null)
            {
                try
                {
                    danhmuc.ten = txtDanhMucDoUong.Text;
                    db.SubmitChanges();
                    MessageBox.Show("cập nhật thành công");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("cập nhật thất bại:" + ex.Message);
                }
            }
            //nếu thêm mới
            else
            {
                danhmuc = new FoodCategory();

                try
                {
                    danhmuc.ten = txtDanhMucDoUong.Text;
                    db.FoodCategories.InsertOnSubmit(danhmuc);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại: " + ex.Message);
                }
            }
        }
        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa danh mục này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(id))
                {
                    danhmuc = db.FoodCategories.FirstOrDefault(x => x.id == int.Parse(id));
                    db.FoodCategories.DeleteOnSubmit(danhmuc);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                    this.Dispose();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
