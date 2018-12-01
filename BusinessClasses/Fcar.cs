namespace ConsoleApp1
{
    class Fcar : Car
    {
        /// <summary>
        /// масса авто
        /// </summary>
        public int mas { get; set; }
        /// <summary>
        /// грузоподъемность
        /// </summary>
        public int cc { get; set; }     

        public Fcar() : base()
        {}

        public Fcar(int mas, int cc, int id, double vdvig, int kpos) : base(id, vdvig, kpos)
        {
            tc = typeCar.fcar;
            this.mas = mas;
            this.cc = cc;
        }

        public void SetParam(int mas, int cc)
        {
            tc = typeCar.fcar;
            this.mas = mas;
            this.cc = cc;
        }

        public override string str()
        {
            string ss = $"{base.str()} масса авто {mas} грузоподъемность {cc}";
            return ss;
        }
    }
}
