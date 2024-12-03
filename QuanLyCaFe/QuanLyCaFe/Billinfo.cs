using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    public class Billinfo
    {
        public Billinfo(int id, int idbill,int idmon, int count)
        {
            this.ID = id;
            this.IDBill = idbill;
            this.IDMon = idmon;
            this.Count = count;
        }
        public Billinfo(DataRow row)
        {
            this.ID = (int)row["id"];
            this.IDBill = (int)row["idBill"];
            this.IDMon = (int)row["idMon"];
            this.Count = (int)row["count"];
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int idbill;
        public int IDBill
        {
            get { return idbill; }
            set { idbill = value; }
        }

        private int idmon;
        public int IDMon
        {
            get { return idmon; }
            set { idmon = value; }
        }

        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
    }
}
