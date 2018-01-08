using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Countable
{
    class Counter<T> where T : ICountable
    {
        public int count;
        public void Add(T item)
        {
            count = item.Count();
        }

        public void Add(IEnumerable<T> items)
        {
            count = items.Count();
        }

        public void Add(IEnumerable<T> items, Func<IEnumerable<T>, int> del)
        {
            count = del(items);
        }
    }
}