using System.Data.SqlClient;

namespace ConsoleApp1
{
    class SerCar
    {
        protected float vdvig;
        protected int kpos;

        public virtual void ser(SqlDataReader reader)
        {
            vdvig = (float)(double)reader["vdvig"];
            kpos = (int)reader["kpos"];
        }

        public Car NewCar()
        {
            return new Car(vdvig, kpos);
        }
    }
}
