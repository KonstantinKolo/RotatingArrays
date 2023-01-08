using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int s1 = 0; s1 < n; s1++)
            {
                arr[s1] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr);
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
