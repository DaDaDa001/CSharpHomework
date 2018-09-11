using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2,num3;
            string s1, s2;
            Console.Write("Please input a number:");
            s1 = Console.ReadLine();
            num1 = double.Parse(s1);
            Console.Write("Please input another number:");
            s2 = Console.ReadLine();
            num2 = double.Parse(s2);
            num3 = num1 * num2;
            Console.WriteLine("num3 = " + num3);
        }
    }
}
