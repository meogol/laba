using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using ConsoleApp1;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ListBdCar = new List<Car>();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString))
            {
                try
                {
                    con.Open();
                    string sqlExpression = "SELECT * FROM car";
                    using (SqlCommand command = new SqlCommand(sqlExpression, con))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                string strok = reader["тип_машины"].ToString();

                                if (strok == "машина")
                                {
                                    ListBdCar.Add(new Car());
                                    ListBdCar[i].Serialize(reader);
                                }
                                else if (strok == "грузовик")
                                {
                                    ListBdCar.Add(new Fcar());
                                    ListBdCar[i].Serialize(reader);
                                }
                                else if (strok == "легковая")
                                {
                                    ListBdCar.Add(new Lcar());
                                    ListBdCar[i].Serialize(reader);
                                }
                                else if (strok == ("тягач"))
                                {
                                    ListBdCar.Add(new Tyag());
                                    ListBdCar[i].Serialize(reader);
                                }
                                i++;
                            }
                            reader.Close();
                        }
                    }
                }
                catch (InvalidOperationException err) //ошибка открытия
                {
                    Console.WriteLine(err);
                    Console.WriteLine(err.StackTrace);
                }
                catch (InvalidCastException err) //ошибка инициализации ридера
                {
                    Console.WriteLine(err);
                    Console.WriteLine(err.StackTrace);
                }
                catch (SqlException err) //отлов ошибок чтения и прочих ошибок sql
                {
                    Console.WriteLine(err);
                    Console.WriteLine(err.StackTrace);
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

            foreach (Car n in ListBdCar)
            {
                string ss = n.str();
                Console.WriteLine(ss);
            }
            Console.ReadKey();
        }
    }   
}
