using Algorithm.Commons.Implement;
using Algorithm.Permutations.Interface;
using System;
using System.Linq;

namespace Algorithm.Permutations.Implement
{
    public class Permutation : Common, IPermutation
    {
        /// <summary>
        /// Business
        /// </summary>
        /// <param name="arrayFirst"></param>
        /// <param name="arraySecond"></param>
        /// <returns></returns>
        public bool BusinessLogic(int[] arrayFirst, int[] arraySecond)
        {
            int count = 0;
            int totalElementFirst = arrayFirst.Length;
            int totalElementSecond = arraySecond.Length;

            if (totalElementFirst != totalElementSecond)
                return false;
            // Check element duplicate two array
            for (int i = 0; i < totalElementFirst; i++)
            {
                if (arrayFirst[i] == arraySecond[i])
                {
                    count++;
                    if (count == totalElementFirst)
                        return false;
                }
            }
            // 
            if (arrayFirst[(totalElementFirst - 1) / 2] == arraySecond[(totalElementSecond - 1) / 2])
            {
                int[] subArrayFirst = arrayFirst.Take(arrayFirst[((totalElementFirst - 1) / 2) - 1]).ToArray();
                int[] subArraySecond = arraySecond.Take(arraySecond[((totalElementSecond - 1) / 2) - 1]).ToArray();
                int[] subArrayFirstLast = arrayFirst.Skip(arrayFirst[(totalElementSecond - 1) / 2]).Take(arrayFirst[totalElementSecond - 1]).ToArray();
                int[] subArraySecondLast = arraySecond.Skip(arraySecond[(totalElementSecond - 1) / 2]).Take(arraySecond[totalElementSecond - 1]).ToArray();
                Array.Sort(subArrayFirst);
                Array.Sort(subArraySecond);
                Array.Sort(subArrayFirstLast);
                Array.Sort(subArraySecondLast);
                if (CheckPermutation(subArrayFirst, subArraySecond) && CheckPermutation(subArrayFirstLast, subArraySecondLast))
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }

        }

        //Check permutation
        public bool CheckPermutation(int[] arrayFirst, int[] arraySecond)
        {
            for (int i = 0; i < arrayFirst.Length; i++)
            {
                if (arrayFirst[i] != arraySecond[i])
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Main of Permutation
        /// </summary>
        public void MainPermutation()
        {
            Console.Write("\t");
            Console.Write("******Question 1****** \n");
            Console.Write("Nhap so phan tu cua mang thu nhat : ");
            int totalElementFirst = int.Parse(Console.ReadLine());

            int[] arrayFirst = new int[totalElementFirst];
            InputArrray(arrayFirst, totalElementFirst);
            OutputArray(arrayFirst, totalElementFirst);

            Console.Write("Nhap so phan tu cua mang thu hai :");
            int totalElementSecond = int.Parse(Console.ReadLine());
            int[] arraySecond = new int[totalElementSecond];
            InputArrray(arraySecond, totalElementSecond);
            OutputArray(arraySecond, totalElementSecond);

            if (BusinessLogic(arrayFirst, arraySecond))
                Console.Write("Output: YES");
            else
                Console.Write("Output: NO");

            Console.ReadKey();
        }
    }
}