using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ConsoleApp1
{
    class DBcars : CachedRepositary<Car>
    {

        public DBcars() {}

        protected override Car Serialize(SqlDataReader reader)
        {
            typeCar strok = (typeCar)reader["typeCar"];
            

            if (strok == typeCar.car)
            {
                Car c= new Car();
                serCar(reader, c);
                return c;
            }
            else if(strok == typeCar.lcar)
            {
                Lcar c = new Lcar();
                serLcar(reader, c);
                return c;
            }
            else if (strok == typeCar.fcar)
            {
                Fcar f = new Fcar();
                serFcar(reader, f);
                return f;
            }
            else if (strok == typeCar.tyag)
            {
                Tyag t = new Tyag();
                serTyag(reader, t);
                return t;
            }    
            return null;
        }
        

        public void serCar(SqlDataReader reader, Car c)
        {
            int id = (int)reader["ID"];
            float vdvig = (float)(double)reader["vdvig"];
            int kpos = (int)reader["kpos"];

            c.SetParam(vdvig, kpos, id);
        }

        public void serFcar(SqlDataReader reader, Fcar f)
        {
            serCar(reader, f);
            int mas = (int)reader["mas"];
            int cc = (int)reader["cc"];

            f.SetParam(mas, cc);
        }

        public void serLcar(SqlDataReader reader, Lcar l)
        {
            serCar(reader, l);
            float ras = (float)(double)reader["ras"];
            int Mspeed = (int)reader["Mspeed"];

            l.SetParam(ras, Mspeed);
        }
        
        public void serTyag(SqlDataReader reader, Tyag t)
        {
            serFcar(reader, t);

            int kPr = (int)reader["kPr"];
            string typeDv = (string)reader["typeDv"];

            t.SetParam(kPr, typeDv);
        }
    }
}
