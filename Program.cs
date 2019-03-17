using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumarable
{
    class Test : IEnumerable<int>
    {
        public int[] Array { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                yield return Array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Test();
            t.Array = new int[3];
            t.Array[0] = 5;
            t.Array[1] = 8;
            t.Array[2] = 52;

            foreach (var item in t.Array)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadKey();
        }
    }
}
