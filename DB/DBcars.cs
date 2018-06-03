using System.Data.SqlClient;

namespace ConsoleApp1
{
    class DBcars : ClassDB<Car>
    {
        enum typeCar { машина = 0, легковая, грузовик, тягач };

        protected override Car Serialize(SqlDataReader reader)
        {
            string strok = reader["typeCar"].ToString();

            if(strok== typeCar.машина.ToString())
            {
                return car(reader);
            }else if(strok == typeCar.легковая.ToString())
            {
               return lcar(reader);
            }
            else if (strok == typeCar.грузовик.ToString())
            {
                return fcar(reader);
            }
            else if (strok == typeCar.тягач.ToString())
            {
                return tyag(reader);
            }
            //switch (strok){
            //    case "машина":
            //        {
                        
            //        }
            //    case "грузовик":
            //        {
                        
            //        }
            //    case "легковая":
            //        {
                       
            //        }
            //    case "тягач":
            //        {
                        
            //        } 
            //}
            return null;
        }

        private Car car(SqlDataReader reader)
        {
            float vdvig = (float)(double)reader["vdvig"];
            int kpos = (int)reader["kpos"];
            return new Car(vdvig, kpos);
        }

        private Car fcar(SqlDataReader reader)
        {
            float vdvig = (float)(double)reader["vdvig"];
            int kpos = (int)reader["kpos"];
            int mas = (int)reader["mas"];
            int cc = (int)reader["cc"];
            return new Fcar(mas, cc, vdvig, kpos);
        }

        private Car lcar(SqlDataReader reader)
        {
            float vdvig = (float)(double)reader["vdvig"];
            int kpos = (int)reader["kpos"];
            float ras = (float)(double)reader["ras"];
            int Mspeed = (int)reader["Mspeed"];
            return new Lcar(ras, Mspeed, vdvig, kpos);
        }

        private Car tyag(SqlDataReader reader)
        {
            float vdvig = (float)(double)reader["vdvig"];
            int kpos = (int)reader["kpos"];
            int mas = (int)reader["mas"];
            int cc = (int)reader["cc"];
            int kPr = (int)reader["kPr"];
            string typeDv = (string)reader["typeDv"];
            return new Tyag(kPr, typeDv, mas, cc, vdvig, kpos);
        }

    }
}
