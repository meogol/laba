using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Lcar : Car
    {
        /// <summary>
        /// расход
        /// </summary>
        float ras { get; set; }
        /// <summary>
        /// макс скорость
        /// </summary>
        int Mspeed { get; set; }      

        public Lcar() : base()
        {
            tc = typeCar.lcar;
            ras = 20;
            Mspeed = 120;
        }
        public Lcar(float ras, int Mspeed, float vdvig, int kpo) : base(vdvig, kpo)
        {
            tc = typeCar.lcar;
            this.ras = ras;
            this.Mspeed = Mspeed;
        }

        public override string str()
        {
            string ss = $"{base.str()} расход {ras} макс скорость {Mspeed}";
            return ss;
        }
    }
}
