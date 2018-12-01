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
        public Lcar(float ras, int Mspeed, int id, double vdvig, int kpos) : base(id, vdvig, kpos)
        {
            tc = typeCar.lcar;
            this.ras = ras;
            this.Mspeed = Mspeed;
        }

        public void SetParam(float ras, int Mspeed)
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
