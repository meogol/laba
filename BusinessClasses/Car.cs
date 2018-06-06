namespace ConsoleApp1
{
    //типы машин
    public enum typeCar { car = 0, lcar, fcar, tyag };
    class Car
    {
        
        /// <summary>
        /// объем двигателя
        /// </summary>
        private float vdvig { get; set; }
        /// <summary>
        /// кол-во посадочных мест
        /// </summary>
        private int kpos { get; set; }
        /// <summary>
        /// тип машины
        /// </summary>
        protected typeCar tc { get; set; }

        public Car()
        {
            tc = typeCar.car;
            vdvig = 14;
            kpos = 6;
        }

        public Car(float vdvig, int kpos)
        {
            tc = typeCar.car;
            this.vdvig = vdvig;
            this.kpos = kpos;
        }

        public virtual string str()
        {
            string ss = $"тип машины {tc} объем двигателя {vdvig} кол-во посадочных мест {kpos}"; 
            return ss;
        }
    }
}
