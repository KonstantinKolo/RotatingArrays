using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string strings = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            string[] stringArr = strings.Split(' ');
            int[] intArr = Array.ConvertAll(stringArr, int.Parse);
            int reverse = 0;
            int[] sum = new int[intArr.Length];
            for (int s1 = 0; s1 < k; s1++)
            {
                reverse = intArr[intArr.Length -1];
                Array.Copy(intArr, 0, intArr, 1, intArr.Length - 1);
                intArr[0] = reverse;
                for (int s2 = 0; s2 < sum.Length; s2++)
                {
                    sum[s2] = sum[s2] + intArr[s2];
                }
            }            
            string result = string.Join(" ", sum);
            Console.WriteLine(result);
        }
    }
}
