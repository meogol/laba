using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Fcar : Car
    {
        int mas { get; set; }
        /// <summary>
        /// масса авто
        /// </summary>
        int cc { get; set; }
        /// <summary>
        /// грузоподъемность
        /// </summary>

        public Fcar() : base()
        {
            base.typeCar = "грузовик";
            mas = 2000;
            cc = 800;
        }

        public Fcar(int mas, int cc, float vdvig, int kpos, string typeCar) : base(vdvig, kpos, typeCar)
        {
            this.mas = mas;
            this.cc = cc;
        }

        public override void Serialize(SqlDataReader reader)
        {
            base.Serialize(reader);
            mas = (int)reader.GetValue(3);
            cc = (int)reader.GetValue(4);
        }

        public override string str()
        {
            string ss = $"{base.str()} масса авто {mas} грузоподъемность {cc}";
            return ss;
        }
    }
}
