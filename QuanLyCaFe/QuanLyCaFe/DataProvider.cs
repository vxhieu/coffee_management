using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCaFe
{
    public class DataProvider
    {
       
        private static DataProvider instance;
        public static DataProvider Instance
        {
            get {if(instance == null) instance = new DataProvider(); return DataProvider.instance;}
            private set { DataProvider.instance = value; }
        }
        private string cn = @"Data Source=.;Initial Catalog=QLCF;Integrated Security=True";
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connect = new SqlConnection(cn))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connect.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connect = new SqlConnection(cn))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connect.Close();
            }
            return data;
        }
        public DataTable ExecuteQuery(string query,object []parameter =null)
        {

            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(cn))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                if(parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listpara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }    
                    }    
                }    
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }
        public DataTable ExecuteQuery(string query)
        {
            
            DataTable data = new DataTable();
            using(SqlConnection connect = new SqlConnection(cn))
            {
                connect.Open();
                SqlCommand command = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }
    }
}
