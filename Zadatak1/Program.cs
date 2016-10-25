using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAUPJC_1_Assignment
{
        class Program
    {
        static void Main(string[] args)
        {
            IntegerList list = new IntegerList(10);
            list.Add(1);
            list.Add(2);
            list.Add(0);
            Console.WriteLine(list.Count);
            list.print();
            list.Remove(3);
          // Console.WriteLine(list.GetElement(10));
        }
    }
}
