using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
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
            list.print();
            System.Console.WriteLine(list.Contains(3.22));
            System.Console.WriteLine(list.GetElement(0));
            
        }
    }
}
