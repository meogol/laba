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
                                ListBdCar.Add(Serialize(reader));
                            }
                            reader.Close();
                        }
                        
                    }
                }
                catch (Exception err) //отлов всех ошибок
                {
                    Console.WriteLine(err.StackTrace);
                    Console.WriteLine(err.Message);
                    Console.WriteLine(err.HelpLink);
                    throw new Exception("Ошибка при попытке выполнить Sql запрос: " + s, err);
                }
            }
            return ListBdCar;
        }

        protected virtual T Serialize(SqlDataReader reader)
        {
            return AddList(reader, typeof(T));
        }
        
        protected T AddList(SqlDataReader reader, Type type)
        {
            T t=(T)Activator.CreateInstance(type);
            
            foreach (PropertyInfo itm in t.GetType().GetProperties())
            {
                if (ColumnExists(reader, itm.Name))
                {
                    itm.SetValue(t, reader[itm.Name]);
                }
            }

            return t;
            
        }

        public bool ColumnExists(IDataReader reader, string columnName)
        {
            return reader.GetSchemaTable().Rows.OfType<DataRow>().Any(row => row["ColumnName"].ToString() == columnName);
        }

    }
}
