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
                    throw new Exception("Ошибка при попытке выполнить Sql запрос: " + s, err);
                }
            }
            return ListBdCar;
        }

        protected virtual T Serialize(SqlDataReader reader)
        {
            IEnumerable<Type> list = Assembly.GetAssembly(typeof(T)).GetTypes().Where(type => type.IsSubclassOf(typeof(T)));
            //пытаемся получить лист наследников, если он не поустой, ищем нужного
            if (list.LastOrDefault() != null)
                foreach (Type itm in list)
                {
                    if (IsEqually(itm, reader))
                    {
                        return AddList(reader, itm);
                    }
                }
            return AddList(reader, typeof(T));
        }
        
        private bool IsEqually(Type type, SqlDataReader reader)//проверяет заполнение столбцов, одноименных для пропертей(служит для определения нужного наследника)
        {
            bool a = true;
            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (reader[prop.Name]== DBNull.Value)
                {
                    a = false;
                    break;
                }
            }

            return a;
        }

        private T AddList(SqlDataReader reader, Type type)
        {
            T t=(T)Activator.CreateInstance(type);
            
            foreach (PropertyInfo itm in t.GetType().GetProperties())
            {
                itm.SetValue(t, reader[itm.Name]);
            }

            return t;
        }

    }
}
