using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using ConsoleApp1;

namespace ConsoleApp3
{
    class Program
    {


        static void Main(string[] args)
        {

            SqlConnection con = new SqlConnection();

            con.ConnectionString = @"server=(local); database=cars; integrated security=true";

            string sqlExpression = "SELECT * FROM car";

            var ListCar = new List<Car>() {
                new Car(),
                new Fcar(),
                new Tyag(1,"2",3,4,5,6, "тягач"),
                new Lcar(1,45,12,35, "легковая")
            };

            foreach (Car n in ListCar)
            {
                string ss = n.str();
                Console.WriteLine(ss);
            }

            var ListBdCar = new List<Car>();

            try
            {

                con.Open();
                SqlCommand command = new SqlCommand(sqlExpression, con);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {

                        string strok = (string)reader.GetValue(9);

                        if (reader.GetValue(9).ToString().Contains("машина"))
                        {
                            ListBdCar.Add(new Car());
                            ListBdCar[i].Serialize(reader);
                        }
                        else if (reader.GetValue(9).ToString().Contains("грузовик"))
                        {
                            ListBdCar.Add(new Fcar());
                            ListBdCar[i].Serialize(reader);
                        }
                        else if (reader.GetValue(9).ToString().Contains("легковая"))
                        {
                            ListBdCar.Add(new Lcar());
                            ListBdCar[i].Serialize(reader);
                        }
                        else if (reader.GetValue(9).ToString().Contains("тягач"))
                        {
                            ListBdCar.Add(new Tyag());
                            ListBdCar[i].Serialize(reader);
                        }
                        i++;
                    }
                    
                }
                reader.Close();
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
            finally
            {

                con.Close();
            }

            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

            foreach (Car n in ListBdCar)
            {
                string ss = n.str();
                Console.WriteLine(ss);
            }

            Console.ReadKey();
        }
    }   
}
