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
        {}
        public Lcar(float ras, int Mspeed, float vdvig, int kpo, int id) : base(vdvig, kpo,id)
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
