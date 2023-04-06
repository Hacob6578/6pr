using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6pr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double x = double.Parse(s);
            double F = Math.Sin(x) * Math.Cos(x);
            Console.WriteLine(x + " " + F);
            Console.ReadKey();
            return;
        }
    }
}
