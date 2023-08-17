using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public partial class Sum
    {
        static void Main(string[] args)
        {
            Sum calc=new Sum();
            calc.Multi(12,23);
            calc.Sum1(70,80);
            calc.Divide(10, 5);
            Console.ReadLine();
        }
    }
}
