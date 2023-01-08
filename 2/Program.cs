using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string strings = Console.ReadLine();
            string[] arrString = strings.Split(' ');
            Array.Reverse(arrString);
            Console.WriteLine(string.Join(" ", arrString));
        }
    }
}
