using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<double> list = new GenericList<double>(10);
            list.Add(3.23);
            list.Add(1.23);
            list.Add(2.323);
            list.Add(4.12);

            IEnumerator<double> enumerator = list.GetEnumerator();
            while (enumerator.MoveNext())
            {
                double value = (double)enumerator.Current;
                Console.WriteLine(value);
            }
        }
    }
}
