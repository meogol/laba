namespace ConsoleApp1
{
    class Types:IIntegerKey
    {
        public int ID { get; set; }
        typeCar tc { get; set; }

        public Types(int id,typeCar str)
        {
            ID = id;
            tc = str;
        }

        public string str()
        {
            string ss = $"id-{ID} тип машины {tc}";
            return ss;
        }

    }
}
