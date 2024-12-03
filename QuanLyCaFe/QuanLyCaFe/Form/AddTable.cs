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
    public partial class AddTable : Form
    {
        private string idban;
        DataClasses1DataContext db = new DataClasses1DataContext();
        TableFood tf = null;
        public AddTable(string idban)
        {
            this.idban = idban;
            InitializeComponent();
            loadDmBan();
        }
        public void loadDmBan()
        {
            //Cập nhật
            if (!string.IsNullOrEmpty(idban))
            {
                label1.Text = "Cập nhật bàn ăn";
                tf = db.TableFoods.FirstOrDefault(x => x.id == int.Parse(idban));
                txtTenBan.Text = tf.tenban;
            }
            else btnXoaBan.Hide();
        }

        private void btnLuuBan_Click(object sender, EventArgs e)
        {
            #region
            if (string.IsNullOrEmpty(txtTenBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên bàn");
                return;
            }
            #endregion
            //nếu cập nhật
            if (tf != null)
            {
                try
                {
                    tf.tenban = txtTenBan.Text;
                    tf.trangthai = "trống";
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
                tf = new TableFood();

                try
                {
                    tf.tenban = txtTenBan.Text;
                    tf.trangthai = "Trống";
                    db.TableFoods.InsertOnSubmit(tf);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa bàn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(idban))
                {
                    tf = db.TableFoods.FirstOrDefault(x => x.id == int.Parse(idban));
                    db.TableFoods.DeleteOnSubmit(tf);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                    this.Dispose();
                }
            }
        }
    }
}
