﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ui_qlnhahang.DAo
{
    public class DataProvider
    {
        
        
            private string connectionSTR = "Data Source=.\\SQLEXPRESS;Initial Catalog=RestaurantManagement;Integrated Security=True";
            private static DataProvider instance;

            public static DataProvider Instance
            {
                get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
                private set => instance = value;
            }
        public DataTable ExecuteQuery(string query, object[] parameter = null)
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                    {

                        connection.Open();
                        SqlCommand command = new SqlCommand(query, connection);

                        if (parameter != null)
                        {
                            string[] listPara = query.Split(' ');
                            int i = 0;
                            foreach (string item in listPara)
                                {
                                if (item.Contains('@'))
                                    {
                                        command.Parameters.AddWithValue(item, parameter[i]);
                                        i++;
                                    }
                        }
                    }

                   SqlDataAdapter adapter = new SqlDataAdapter(command);
                        
                        adapter.Fill(data);

                        connection.Close();
                    
                    }
                return data;
            }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public void ExecuteNonQuery(string name ,string query, object[] parameter = null)
        {
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(name, connection);
                command.CommandType = CommandType.StoredProcedure;
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }

    }
}
