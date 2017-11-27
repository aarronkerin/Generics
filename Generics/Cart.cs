using Generics.Countable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Cart : ICountable
    {
        public List<Box> boxes;

        public int Count()
        {
            int total = 0;

            foreach (var box in boxes)
            {
                total += box.Count();
            }
            return total;
        }
    }
}
