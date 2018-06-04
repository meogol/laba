using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class ClassDB<T>
    {

        public virtual List<T> Load(string s)
        {
            List<T> ListBdCar = new List<T>();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sqlExpression = s;//s- передоваемый запрос
                    using (var command = new SqlCommand(sqlExpression, con))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListBdCar.Add(Serialize(reader));
                            }
                            reader.Close();
                        }
                    }
                }
                catch (Exception err) //отлов всех ошибок
                {
                    Console.WriteLine(err);
                }
            }
                return ListBdCar;
        }

        protected virtual T Serialize(SqlDataReader reader)//считываем и создаем новый эллемент
        {
            return  default(T);
        }
    }
}
