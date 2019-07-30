using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class MyClass
    {
        int[] array;

        public void MyArray(int n)
        {
            array = new int[Math.Abs(n)];
            Random random = new Random();
            for(int i=0; i<array.Length; i++)
            {
                array[i] = random.Next(0, 40);
                Console.Write("{0} ", array[i]);
 
            }
            Console.WriteLine();
        }

        public void MinMax()
        {
            int min = array[0];
            int max = array[0];
            for (int i = 0; i <array.Length; i++)
            {
                max = Math.Max(max, array[i]);
                min = Math.Min(min, array[i]);               
            }
            Console.Write("Min={0} , Max={1}", min, max);
            Console.WriteLine();
        }

        public int Sum()
        {
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
               sum += array[i];
            }
        return sum;

        }

        public int Average()
        {
            return Sum() / array.Length;
        }

        public void Odd()
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)

                    Console.Write("{0} ",array[i]);
            }
        }


    }
}
