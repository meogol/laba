using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class DBcars : ClassDB<Car>
    {
        float vdvig;
        int kpos;
        int mas;
        int cc;
        float ras;
        int Mspeed;
        int kPr;
        string typeDv;
        protected override Car Serialize(SqlDataReader reader)
        {
            typeCar strok = (typeCar)reader["typeCar"];
            
            if(strok == typeCar.car)
            {
                serCar(reader);
                return new Car(vdvig, kpos);
            }
            else if(strok == typeCar.lcar)
            {
                serLcar(reader);
                return new Lcar(ras, Mspeed, vdvig, kpos);
            }
            else if (strok == typeCar.fcar)
            {
                serFcar(reader);
                return new Fcar(mas, cc, vdvig, kpos );
            }
            else if (strok == typeCar.tyag)
            {
                serTyag(reader);
                return new Tyag(kPr, typeDv, mas, cc, vdvig, kpos);
            }    
            return null;
        }

        public void serCar(SqlDataReader reader)
        {
            vdvig = (float)(double)reader["vdvig"];
            kpos = (int)reader["kpos"];   
        }

        public void serFcar(SqlDataReader reader)
        {
            serCar(reader);
            mas = (int)reader["mas"];
            cc = (int)reader["cc"];
        }

        public void serLcar(SqlDataReader reader)
        {
            serCar(reader);
            ras = (float)(double)reader["ras"];
            Mspeed = (int)reader["Mspeed"];
        }
        
        public void serTyag(SqlDataReader reader)
        {
            serFcar(reader);
            kPr = (int)reader["kPr"];
            typeDv = (string)reader["typeDv"];
        }
    }
}
