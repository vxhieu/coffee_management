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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Thoát chương trình
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
        //nút login
        private void button1_Click(object sender, EventArgs e)
        {
            
            DataClasses1DataContext cf = new DataClasses1DataContext();
            var username = cf.Accounts.SingleOrDefault(d => d.username.Equals(textuser.Text));
            var password = cf.Accounts.SingleOrDefault(d => d.password1.Equals(txtpass.Text));

            var tk = cf.Accounts.SingleOrDefault(d => d.username == textuser.Text && d.password1 == txtpass.Text);


            if (textuser.Text == "" || txtpass.Text == "")
            {
                MessageBox.Show("Vui lòng điền tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (tk != null)
                {
                    QuanLys ql = new QuanLys(username.loaitaikhoan, username.tenhienthi);
                    this.Hide();
                    ql.ShowDialog();
                    this.Show();
                }
                else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            ////QuanLys ql = new QuanLys(1);
            //        this.Hide();
            //        ql.ShowDialog();
            //        this.Show();
        }
        //nút exit
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
