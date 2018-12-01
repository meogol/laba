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
                            reader.Close();
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
            Assembly asm = Assembly.LoadFrom("ConsoleApp2.exe");

            Type[] allTypes = asm.GetTypes();

            foreach (Type temp in allTypes)
            {
                if (IsEqually(temp.GetProperties(), reader) && temp.IsInterface == false)
                {
                    List<object> list = new List<object>();

                    foreach (PropertyInfo prop in temp.GetProperties())
                    {
                        list.Add(reader[prop.Name]);
                    }

                    return (T)Activator.CreateInstance(temp, list.ToArray());
                }
            }
            return default(T);
        }

       
        private bool IsEqually(PropertyInfo[] properties, SqlDataReader reader)
        {
            int count = 0;
            bool a = false;
            foreach (PropertyInfo prop in properties)
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i) == prop.Name && prop.Name != "typeCar")
                    {
                        count++;
                        a = true;
                        break;
                    }
                    else
                        a = false;
                }
            }
            if (count < properties.Count())
                a = false;
            return a;
        }

    }
}
