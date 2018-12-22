namespace ConsoleApp1
{
    class Types:IIntegerKey
    {
        public int ID { get; set; }
        public typeCar type_car { get; set; }
        
        public Types() { }

        public Types(int id,typeCar str)
        {
            ID = id;
            type_car = str;
        }

        public string str()
        {
            string ss = $"id-{ID} тип машины {type_car}";
            return ss;
        }

    }
}
