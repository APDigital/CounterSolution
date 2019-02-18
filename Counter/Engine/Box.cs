using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Box<T> : ICountable
    {
        int count;
        private List<Apple> appleList = new List<Apple>();
        private List<Orange> orangeList = new List<Orange>();
        public List<Apple> AppleList { get; private set; }
        public List<Orange> OrangeList { get; private set; }
        public Box()
        {
            AppleList = appleList;
            OrangeList = orangeList;
        }
        public Box(List<Apple> Item)
        {
            count = Item.Count();
            foreach (var item in Item)
            {
                appleList.Add(item);
            }
            AppleList = appleList;
        }
        public Box(List<Orange> Item)
        {
            count = Item.Count();
            foreach (var item in Item)
            {
                orangeList.Add(item);
            }
            OrangeList = orangeList;
        }

        public int Count()
        {
            return count;
        }

    }
}
