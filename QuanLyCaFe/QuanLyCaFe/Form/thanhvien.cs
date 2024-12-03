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
    public partial class thanhvien : Form
    {
        private string idtv;
        DataClasses1DataContext db = new DataClasses1DataContext();
        ThanhVien tv = null;
        public thanhvien(string idtv)
        {
            this.idtv = idtv;
            InitializeComponent();
            loaddmthanhvien();
        }

        public void loaddmthanhvien()
        {
            //Cập nhật
            if (!string.IsNullOrEmpty(idtv))
            {
                tv = db.ThanhViens.FirstOrDefault(x => x.mathanhvien == int.Parse(idtv));
                txttentv.Text = tv.TenThanhVien;
                textsdt.Text = tv.SDT;
                textngaysinh.Text = tv.NgaySinh.ToString();
            }
            else btnXoatv.Hide();
        }

        private void btnLuuTV_Click(object sender, EventArgs e)
        {
            #region
           //nếu cập nhật
            if (tv != null)
            {
                try
                {
                    tv.TenThanhVien = txttentv.Text;
                    tv.SDT = textsdt.Text;
                    tv.NgaySinh = DateTime.Parse(textngaysinh.Text);
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
                tv = new ThanhVien();
                try
                {
                    tv.TenThanhVien = txttentv.Text;
                    tv.SDT = textsdt.Text;
                    tv.NgaySinh = DateTime.Parse(textngaysinh.Text);
                    db.ThanhViens.InsertOnSubmit(tv);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại: " + ex.Message);
                }
            }
            #endregion
        }
    }
}
