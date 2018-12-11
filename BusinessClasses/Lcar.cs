namespace ConsoleApp1
{
    class Lcar : Car
    {
        /// <summary>
        /// расход
        /// </summary>
        public double ras { get; set; }
        /// <summary>
        /// макс скорость
        /// </summary>
        public int Mspeed { get; set; }      

        public Lcar() : base()
        {}
        public Lcar(double ras, int Mspeed, double vdvig, int kpo, int id) : base(vdvig, kpo,id)
        {
            typeCar = typeCar.lcar;
            this.ras = ras;
            this.Mspeed = Mspeed;
        }

        public void SetParam(double ras, int Mspeed)
        {
            typeCar = typeCar.lcar;
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
