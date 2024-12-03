using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    public class Table
    {
        public Table(int id, string tenban, string trangthai)
        {
            this.ID = id;
            this.Tenban = tenban;
            this.Trangthai = trangthai;
        }
        public Table(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Tenban = row["tenban"].ToString();
            this.Trangthai = row["trangthai"].ToString();
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value;}
        }
        private string tenban;
        public string Tenban
        {
            get { return tenban; }
            set { tenban = value; }
        }
        private string trangthai;
        public string Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    } 
}
