using Algorithm.MostFrequentNumbers.Implement;
using Algorithm.Permutations.Implement;
using System;

namespace Algorithm
{
    internal class Program
    {
        /// <summary>
        /// Root Main: run program algorithm
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            //Permutation permutation = new Permutation();
            //permutation.MainPermutation();

            //MostFrequentNumber mostFrequentNumber = new MostFrequentNumber();
            //mostFrequentNumber.MainMostFrequentNumber();
            int[] array = new int[10] { 3, 4, 3, 5, 5, 3,5, 1,1,1};
            int count = 1, tempCount;
            int frequentNumber = array[0];
            int tempNumber = 0;
            for (int i = 0; i < (array.Length - 1); i++)
            {
                tempNumber = array[i];
                tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (tempNumber == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine("The most frequent number in this array is {0} has been repeated {1} times.", frequentNumber, count);
            Console.ReadKey();
        }
    }
}