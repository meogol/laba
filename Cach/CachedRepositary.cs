using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class CachedRepositary<T>:BaseRepository<T> where T:IIntegerKey
    {

        protected Dictionary<int, T> cache = new Dictionary<int, T>();
        
        public T LoadById(int id)
        {
            
            if (cache.TryGetValue(id, out T value))
            {
                return value;
            }

            List<T> list = Load($"SELECT * FROM car WHERE ID={id}");
            return list.FirstOrDefault();
        }
        
        public override List<T> Load(string s)
        {
            List<T> list= base.Load(s);

            foreach (T tList in list)
            {
                if (!cache.ContainsKey(tList.ID))//проверяем, есть ли элемент в кэше
                {
                    cache.Add(tList.ID, tList);
                }
            }
            return list;
        }

        public List<T> LoadFromCacheByLinq(Func<T,bool> predicate)
        {
            List<T> list = cache.Values.Where(predicate).ToList();
            
            return list;
        }
    }
}
