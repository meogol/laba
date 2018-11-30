using System;

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
        public float vdvig { get; set; }
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

        public Car(object id, object vdvig, object kpos )
        {
            ID = (int)id;
            typeCar = typeCar.car;
            this.vdvig = (float)(double)vdvig;
            this.kpos = (int)kpos;
        }

        public void SetParam(float vdvig, int kpos , int id)
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
