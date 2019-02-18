using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Box<T> : ICountable
    {
        int count;

        public Box(List<T> Item)
        {
            count = Item.Count();
           
        }
        public int Count()
        {
            return count;
        }
        
    }
   
}
