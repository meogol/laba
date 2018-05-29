using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    public class ClassDB<T>
    {
        protected List<T> ListBdCar = new List<T>();

        public virtual List<T> Load(string s)
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sqlExpression = "SELECT * FROM "+s;//s указывает на открываемую бд
                    using (SqlCommand command = new SqlCommand(sqlExpression, con))
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
                    Console.WriteLine(err.StackTrace);
                }
                finally
                {

                    con.Close();
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
