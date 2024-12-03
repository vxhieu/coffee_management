using IKVM.Runtime;
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
    public partial class AddProduct : Form
    {
        private string id;
        Food mh = null;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public AddProduct(string id)
        {
            this.id = id;
            InitializeComponent();
            loadDmloaiDoUong(); 
        }
        public void loadDmloaiDoUong()
        {
            cbLoai.DataSource = db.FoodCategories.ToList();
            cbLoai.DisplayMember = "ten";
            cbLoai.ValueMember = "id";
            //Cập nhật
            if (!string.IsNullOrEmpty(id))
            {
                label1.Text = "Cập nhật sản phẩm";
                mh = db.Foods.FirstOrDefault(x => x.id == int.Parse(id));
                txtDoUong.Text = mh.tenmon;
                txtDongia.Text = mh.dongia.ToString();
                cbLoai.SelectedValue = mh.idCategory;   
            }
            else btnXoa.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            #region
            if (string.IsNullOrEmpty(txtDoUong.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đồ uống");
                return;
            }
            if (string.IsNullOrEmpty(txtDongia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                return;
            }
            try
            {
                var dg = int.Parse(txtDongia.Text);
                if (dg < 0)
                {
                    MessageBox.Show("Đơn giá không hợp lệ");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Đơn giá không hợp lệ");
                return;
            }
            #endregion
            //nếu cập nhật
            if (mh!=null)
            {
                try
                {
                    mh.tenmon = txtDoUong.Text;
                    mh.dongia = int.Parse(txtDongia.Text);
                    mh.idCategory = int.Parse(cbLoai.SelectedValue.ToString());
                    db.SubmitChanges();
                    MessageBox.Show("cập nhật thành công");
                    this.Dispose();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("cập nhật thất bại:"+ex.Message);
                }
            }
            //nếu thêm mới
            else
            {
                mh = new Food();
                
                try
                {
                    mh.tenmon = txtDoUong.Text;
                    mh.dongia = int.Parse(txtDongia.Text);
                    mh.idCategory = int.Parse(cbLoai.SelectedValue.ToString());
                    db.Foods.InsertOnSubmit(mh);
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
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (!string.IsNullOrEmpty(id))
                {
                    mh = db.Foods.FirstOrDefault(x => x.id == int.Parse(id));
                    db.Foods.DeleteOnSubmit(mh);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                    this.Dispose();
                }
                
            }    
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
