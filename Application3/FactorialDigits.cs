using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application3
{
    public class mainfuncation
    {
        public int mainfun()
        {
            int number = 0, num = 0, mul = 1, sumofdigits = 0;
            Console.WriteLine("Enter the Number :");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                mul = mul * i;
            }
            string strsum = Convert.ToString(mul);
            int[] intarr = new int[strsum.Length];
            for (int j = 0; j < strsum.Length; j++)
            {
                intarr[j] = Convert.ToInt32(strsum[j] - '0');
                sumofdigits = sumofdigits + Convert.ToInt32(intarr[j]);
            }
            Console.WriteLine("Sum Of Digits :" + sumofdigits);
            return sumofdigits;
        }
    }
    class FactorialDigits
    {
        static void Main(string[] args)
        {
            mainfuncation mf = new mainfuncation();
            mf.mainfun();
            Console.ReadKey();
        }
    }
}
