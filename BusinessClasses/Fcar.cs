namespace ConsoleApp1
{
    class Fcar : Car
    {
        /// <summary>
        /// масса авто
        /// </summary>
        int mas { get; set; } 
        /// <summary>
        /// грузоподъемность
        /// </summary>
        int cc { get; set; }     

        public Fcar() : base()
        {
            tc = typeCar.fcar;
            mas = 2000;
            cc = 800;
        }

        public Fcar(int mas, int cc, float vdvig, int kpos) : base(vdvig, kpos)
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
