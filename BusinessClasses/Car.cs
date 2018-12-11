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
        public double vdvig { get; set; }
        /// <summary>
        /// кол-во посадочных мест
        /// </summary>
        public int kpos { get; set; }
        /// <summary>
        /// тип машины
        /// </summary>
        public typeCar typeCar { get; set; }

        public Car()
        {}

        public Car(double vdvig, int kpos, int id)
        {
            ID = id;
            typeCar = typeCar.car;
            this.vdvig = vdvig;
            this.kpos = kpos;
        }

        public void SetParam(double vdvig, int kpos, int id)
        {
            ID = id;
            typeCar = typeCar.car;
            this.vdvig = vdvig;
            this.kpos = kpos;
        }

        public virtual string str()
        {
            string ss = $"ID-{ID} тип машины {typeCar} объем двигателя {vdvig} кол-во посадочных мест {kpos}"; 
            return ss;
        }
    }
}
