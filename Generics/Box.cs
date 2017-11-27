using Generics.Countable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public abstract class Box : ICountable

    {
        public abstract int Count();
    }
    public class Box<T> : Box where T : ICountable
    {
        public List<T> items;
        public override int Count()
        {
            int total = 0;

            foreach (var item in items)
            {
                total += item.Count();
            }
            return total;
        }
    }
}
