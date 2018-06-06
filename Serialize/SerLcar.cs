using System.Data.SqlClient;

namespace ConsoleApp1
{
    class SerLcar : SerCar
    {
        protected float ras;
        protected int Mspeed;
        public override void ser(SqlDataReader reader)
        {
            base.ser(reader);
            ras = (float)(double)reader["ras"];
            Mspeed = (int)reader["Mspeed"];
        }

        public Lcar NewLcar()
        {
            return new Lcar(ras, Mspeed, vdvig, kpos);
        }
        
    }
}
