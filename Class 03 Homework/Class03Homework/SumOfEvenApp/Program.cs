using System;

namespace SumOfEvenApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] integerArray = new int[6];
            integerArray[0] = 4;
            integerArray[1] = 3;
            integerArray[2] = 7;
            integerArray[3] = 3;
            integerArray[4] = 2;
            integerArray[5] = 8;

            int sum = 0;

            for (int i = 0; i < integerArray.Length; i++)
            {
                if (integerArray[i] % 2 == 0)
                {
                    sum += integerArray[i];
                }
            }
            Console.WriteLine($"The result is {sum}");
        }
    }
}