using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyCaFe
{
    public class Catelogy
    {
        public Catelogy(string ten, int id)
        {
            this.ID = id;
            this.Ten = ten;
        }
        public Catelogy(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Ten = row["ten"].ToString();
        }
        private string ten;
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}
