using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    
    public static class Summator
    {
        public static long sum(int[] arr) 
        {
            long sum = 0;
            for (int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static double average(double[] arr) 
        {
            double sum = 0;

            for (int i = 0; i <arr.Length; i++ )
            {
                sum += arr[i];
            }
            return sum/arr.Length;
        }

        public static double multiplyNNumbers(double[] arr)
        {
            double product = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                product *= arr[i];
            }
            return product;
        }

    }
}
