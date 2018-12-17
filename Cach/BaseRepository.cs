using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaseRepository<T>
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
                                ListBdCar.Add(Serialize(reader, typeof(T)));
                            }
                            reader.Close();
                        }
                        
                    }
                }
                catch (Exception err) //отлов всех ошибок
                {
                    Console.WriteLine(err.ToString());
                    throw new Exception("Ошибка при попытке выполнить Sql запрос: " + s, err);
                }
            }
            return ListBdCar;
        }

        protected virtual T Serialize(SqlDataReader reader, Type type)
        {
            T t = (T)Activator.CreateInstance(type);

            foreach (PropertyInfo itm in t.GetType().GetProperties())
            {
                itm.SetValue(t, reader[itm.Name]);
                
            }

            return t;
        }
        
        public bool ColumnExists(IDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i) == columnName)
                    return true;
            }

            return false;
        }

    }
}
