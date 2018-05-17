using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Fcar : Car
    {
        /// <summary>
        /// грузоподъемность
        /// </summary>
        int mas { get; set; }
        /// <summary>
        /// масса авто
        /// </summary>
        int cc { get; set; }     

        public Fcar() : base()
        {
            tc = typeCar.грузовик;
            mas = 2000;
            cc = 800;
        }

        public Fcar(int mas, int cc, float vdvig, int kpos) : base(vdvig, kpos)
        {
            tc = typeCar.грузовик;
            this.mas = mas;
            this.cc = cc;
        }

        public override void Serialize(SqlDataReader reader)
        {
            base.Serialize(reader);
            mas = (int)reader["масса_авто"];
            cc = (int)reader["грузоподъемность"];
        }

        public override string str()
        {
            string ss = $"{base.str()} масса авто {mas} грузоподъемность {cc}";
            return ss;
        }
    }
}
