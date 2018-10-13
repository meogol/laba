namespace ConsoleApp1
{
    //типы машин
    public enum typeCar { car = 0, lcar, fcar, tyag };
    class Car: IIntegerKey
    {
        /// <summary>
        /// ID эллемента
        /// </summary>
        public int ID { get; set; }
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
        {}

        public Car(float vdvig, int kpos, int id)
        {
            ID = id;
            tc = typeCar.car;
            this.vdvig = vdvig;
            this.kpos = kpos;
        }

        public void SetParam(float vdvig, int kpos, int id)
        {
            ID = id;
            tc = typeCar.car;
            this.vdvig = vdvig;
            this.kpos = kpos;
        }

        public virtual string str()
        {
            string ss = $"ID-{ID} тип машины {tc} объем двигателя {vdvig} кол-во посадочных мест {kpos}"; 
            return ss;
        }
    }
}
