using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    class Member
    {
        public Member(int mathanhvien, string tenthanhvien, string sdt, int diemtichluy, decimal phantramtichluy, DateTime ngaysinh)
        {
            this.Mathanhvien = mathanhvien;
            this.Tenthanhvien = tenthanhvien;
            this.SDT = sdt;
            this.Diemtichluy = diemtichluy;
            this.Phantramtichluy = phantramtichluy;
            this.NgaySinh = ngaysinh;
        }
        public Member(DataRow row)
        {
            this.Mathanhvien = (int)row["mathanhvien"];
            this.Tenthanhvien = row["tenthanhvien"].ToString();
            this.SDT = row["sdt"].ToString();
            this.NgaySinh = (DateTime)row["ngaysinh"];
            this.Diemtichluy = (int)row["diemtichluy"];
            this.Phantramtichluy = (decimal)row["phantramtichluy"];
        }
        private DateTime ngaysinh;
        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private int mathanhvien;
        public int Mathanhvien
        {
            get { return mathanhvien; }
            set { mathanhvien = value; }
        }
        private string tenthanhvien;
        public string Tenthanhvien
        {
            get { return tenthanhvien; }
            set { tenthanhvien = value; }
        }
        private string sdt;
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private int diemtichluy;
        public int Diemtichluy
        {
            get { return diemtichluy; }
            set { diemtichluy = value; }
        }
        private decimal phantramtichluy;
        public decimal Phantramtichluy
        {
            get { return phantramtichluy; }
            set { phantramtichluy = value; }
        }

    }
}
