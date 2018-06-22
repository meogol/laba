using System.Data.SqlClient;

namespace ConsoleApp1
{
    class SerFcar : SerCar
    {
        protected int mas;
        protected int cc;
        public override void ser(SqlDataReader reader)
        {
            base.ser(reader);
            mas = (int)reader["mas"];
            cc = (int)reader["cc"];
        }

        public Fcar NewFcar()
        {
            return new Fcar(mas, cc, vdvig, kpos);
        }
    }
}
