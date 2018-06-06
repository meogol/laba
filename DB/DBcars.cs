using System.Data.SqlClient;

namespace ConsoleApp1
{
    class DBcars : ClassDB<Car>
    {

        protected override Car Serialize(SqlDataReader reader)
        {
            string strok = reader["typeCar"].ToString();

            if(strok== typeCar.car.ToString())
            {
                SerCar n = new SerCar();
                n.ser(reader);
                return n.NewCar();
            }else if(strok == typeCar.lcar.ToString())
            {
                SerLcar n = new SerLcar();
                n.ser(reader);
                return n.NewLcar();
            }
            else if (strok == typeCar.fcar.ToString())
            {
                SerFcar n = new SerFcar();
                n.ser(reader);
                return n.NewFcar();
            }
            else if (strok == typeCar.tyag.ToString())
            {
                SerTyag n = new SerTyag();
                n.ser(reader);
                return n.NewTyag();
            }    
            return null;
        }
    }
}
