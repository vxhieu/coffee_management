using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    public class Drink
    {
        public Drink(int id, string tenmon, int idcategory, decimal dongia)
        {
            this.ID = id;
            this.Tenmon = tenmon;
            this.IDCategory = idcategogy;
            this.Dongia = dongia;
        }
        public Drink(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Tenmon = row["tenmon"].ToString();
            this.IDCategory = (int)row["idCategory"];
            this.Dongia = (decimal)row["dongia"];
        }
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        private string tenmon;
        public string Tenmon
        {
            get { return tenmon; }
            set { tenmon = value; }
        }
        private int idcategogy;
        public int IDCategory
        {
            get { return idcategogy; }
            set { idcategogy = value; }
        }
        private decimal dongia;
        public decimal Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }
    }
}
