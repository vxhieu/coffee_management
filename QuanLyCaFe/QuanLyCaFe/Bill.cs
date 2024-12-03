using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    public class Bill
    {
        public Bill(int id, DateTime? ngayvao,int idban,int trangthai,int discount)
        {
            this.ID = id;
            this.Ngayvao = ngayvao;
            this.IDban = idban;
            this.Trangthai = trangthai;
            this.Discount = discount = 0;
        }
        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Ngayvao = (DateTime?)row["ngayvao"];
            this.IDban = (int)row["idBan"];
            this.Trangthai = (int)row["trangthai"];
            this.Discount = (int)row["discount"]; 
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private DateTime? ngayvao;
        public DateTime? Ngayvao
        {
            get { return ngayvao; }
            set { ngayvao = value; }
        }

        private int idban;
        public int IDban
        {
            get { return idban; }
            set { idban = value; }
        }

        private int trangthai;
        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        private int discount;
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }
    }
}
