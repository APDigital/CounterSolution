using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
   public class Apple : ICountable
    {
        public string colour { get; set; }
        public int Count()
        {
            return 1;
        }
    }
}
