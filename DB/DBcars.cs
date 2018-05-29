using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DBcars : ClassDB<Car>
    {
        
        protected override Car Serialize(SqlDataReader reader)
        {
            string strok = reader["typeCar"].ToString();
             
            switch (strok){
                case "машина":
                    {
                        float  vdvig = (float)(double)reader["vdvig"];
                        int kpos = (int)reader["kpos"];
                        return new Car(vdvig, kpos);
                        
                    }
                case "грузовик":
                    {
                        float vdvig = (float)(double)reader["vdvig"];
                        int kpos = (int)reader["kpos"];
                        int mas = (int)reader["mas"];
                        int cc = (int)reader["cc"];
                        return new Fcar(mas, cc,vdvig, kpos);
                    }
                case "легковая":
                    {
                        float vdvig = (float)(double)reader["vdvig"];
                        int kpos = (int)reader["kpos"];
                        float ras = (float)(double)reader["ras"];
                        int Mspeed = (int)reader["Mspeed"];
                        return new Lcar(ras, Mspeed, vdvig, kpos);
                    }
                case "тягач":
                    {
                        float vdvig = (float)(double)reader["vdvig"];
                        int kpos = (int)reader["kpos"];
                        int mas = (int)reader["mas"];
                        int cc = (int)reader["cc"];
                        int kPr = (int)reader["kPr"];
                        string typeDv = (string)reader["typeDv"];
                        return new Tyag(kPr, typeDv, mas, cc,vdvig, kpos);
                    } 
            }
            return null;
        }

    }
}
