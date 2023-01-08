using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string strings = Console.ReadLine();
            string[] stringArr = strings.Split(' ');
            int[] intArr = Array.ConvertAll(stringArr, int.Parse);
            int[] arrStart = new int[intArr.Length / 4];
            int[] arrEnd = new int[intArr.Length / 4];
            int[] arrFixed = new int[intArr.Length / 2];
            int[] arrAnsw = new int[intArr.Length / 2];
            Array.Copy(intArr, 0, arrStart, 0, arrStart.Length); //get the first k/4 numbers
            Array.Copy(intArr, intArr.Length / 4 * 3, arrEnd, 0, arrEnd.Length); //get the last k/4 numbers
            //Reverse the first and last k/4 numbers
            Array.Reverse(arrStart);
            Array.Reverse(arrEnd);
            //Get the numbers in the middle
            for (int s1 = intArr.Length / 4; s1 < intArr.Length - (intArr.Length / 4); s1++)
            {
                arrFixed[s1 - intArr.Length / 4] = intArr[s1];
            }
            //get the first half of the answer
            for (int s2 = 0; s2 < intArr.Length / 4; s2++) 
            {
                arrAnsw[s2] = arrStart[s2] + arrFixed[s2];
            }
            //get the last half of answer
            for (int s3 = arrAnsw.Length / 2; s3 < arrAnsw.Length; s3++)
            {
                arrAnsw[s3] = arrFixed[s3] + arrEnd[s3 - arrAnsw.Length / 2];
            }
            string result = string.Join(" ", arrAnsw); //put the answer in a string
            Console.WriteLine(result);
        }
    }
}
