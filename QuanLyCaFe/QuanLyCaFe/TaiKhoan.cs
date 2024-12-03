using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    public class TaiKhoan
    {
        public TaiKhoan(int id, string tenhienthi, string username, string password, int loaitaikhoan)
        {
            this.ID = id;
            this.Tenhienthi = tenhienthi;
            this.Username = username;
            this.Password = password;
            this.Loaitaikhoan = loaitaikhoan;
        }
        public TaiKhoan(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Tenhienthi = row["tenhienthi"].ToString();
            this.Username = row["username"].ToString();
            this.Password = row["password1"].ToString();
            this.Loaitaikhoan = (int)row["loaitaikhoan"];
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string tenhienthi;
        public string Tenhienthi
        {
            get { return tenhienthi; }
            set { tenhienthi = value; }
        }
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int loaitaikhoan;
        public int Loaitaikhoan
        {
            get { return loaitaikhoan; }
            set { loaitaikhoan = value; }
        }
    }
}
