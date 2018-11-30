using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BaseRepository<T> where T : IIntegerKey
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
                        }
                    }
                }
                catch (Exception err) //отлов всех ошибок
                {
                    throw new Exception("Ошибка при попытке выполнить Sql запрос: " + s, err);
                }
            }
            return ListBdCar;
        }

        protected virtual T Serialize(SqlDataReader reader)//считываем и создаем новый эллемент
        {
            Type type = Type.GetType("ConsoleApp1.Car", false, true);
            Type type1 = Type.GetType("ConsoleApp1.Fcar", false, true);
            Type type2 = Type.GetType("ConsoleApp1.Lcar", false, true);
            Type type3 = Type.GetType("ConsoleApp1.Tyag", false, true);

            if (IsEqually(type3.GetProperties(), reader).LastOrDefault() != null)
            {
                return (T)Activator.CreateInstance(type3, IsEqually(type3.GetProperties(), reader).ToArray());
            }
            else if (IsEqually(type2.GetProperties(), reader).LastOrDefault() != null)
            {
                return (T)Activator.CreateInstance(type2, IsEqually(type2.GetProperties(), reader).ToArray());
            }
            else if (IsEqually(type1.GetProperties(), reader).LastOrDefault() != null)
            {
                return (T)Activator.CreateInstance(type1, IsEqually(type1.GetProperties(), reader).ToArray());
            }
            else
            {
                return (T)Activator.CreateInstance(type, IsEqually(type.GetProperties(), reader).ToArray());
            }
        }

        private List<object> IsEqually(PropertyInfo[] properties, SqlDataReader reader)
        {
            List<object> list = new List<object>();
            foreach (PropertyInfo prop in properties)
            {
                if (reader[prop.Name].ToString() != null && reader[prop.Name].ToString() != "")
                {
                    if(prop.Name!= "typeCar")
                        list.Add(reader[prop.Name]);
                    continue;
                }
                else
                {
                    break;
                }
            }
            return list;
        }

    }
}
