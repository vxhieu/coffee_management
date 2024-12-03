using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCaFe
{
    public class Menu
    {
        public Menu (string ma, string tenmon, int count, decimal dongia, decimal totalprice, string ghichu)
        {
            this.Ma = ma;
            this.Tenmon = tenmon;
            this.Count = count;
            this.Dongia = dongia;
            this.Totalprice = totalprice;
            this.GhiChu = ghichu;
        }
        public Menu(DataRow row)
        {
            this.Ma = row["ma"].ToString();
            this.Tenmon = row["tenmon"].ToString();
            this.Count = (int)row["count"];
            this.Dongia = (decimal)row["dongia"];
            this.Totalprice = (decimal)row["totalprice"];
            this.GhiChu = row["ghichu"].ToString();
        }
        private decimal totalprice;
        public decimal Totalprice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }
        private decimal dongia;
        public decimal Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        private string tenmon;
        public string Tenmon
        {
            get { return tenmon; }
            set { tenmon = value; }
        }
        private string ma;
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        private string ghichu;
        public string GhiChu
        {
            get { return ghichu; }
            set { ghichu = value; }
        }
    }
}
