namespace ConsoleApp1
{
    class Types
    {
        int id { get; set; }
        public enum typeCar { car = 0, lcar, fcar, tyag };
        typeCar tc { get; set; }

        public Types(int id, string str)
        {
            this.id = id;

            if (str == typeCar.car.ToString())
                tc = typeCar.car;
            else if (str == typeCar.lcar.ToString())
                tc = typeCar.lcar;
            else if (str == typeCar.fcar.ToString())
                tc = typeCar.fcar;
            else if (str == typeCar.tyag.ToString())
                tc = typeCar.tyag;
        }

        public string str()
        {
            string ss = $"id {id} тип машины {tc}";
            return ss;
        }

    }
}
