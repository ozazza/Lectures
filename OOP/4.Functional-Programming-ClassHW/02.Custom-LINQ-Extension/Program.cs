using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_LINQ_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(2);
            queue.Enqueue(24);
            queue.Enqueue(72);
            queue.Enqueue(23);
            queue.Enqueue(12);
            queue.Enqueue(2);
        
            var result = queue.WhereNot<T>(x=> x % 3)
        }
    }
}
