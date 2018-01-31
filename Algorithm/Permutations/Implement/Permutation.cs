using Algorithm.Commons.Implement;
using Algorithm.Permutations.Interface;
using System;

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
            int totalElementFirst = arrayFirst.Length;
            int totalElementSecond = arraySecond.Length;

            if (totalElementFirst != totalElementSecond)
                return false;

            // Check array permutation
            for (int i = 0; i < totalElementFirst; i++)
            {
                if (arrayFirst[i] == arraySecond[i])
                    return false;
                else
                    return true;
            }

            Array.Sort(arrayFirst);
            Array.Sort(arraySecond);

            for (int i = 0; i < totalElementFirst; i++)
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

            int[] arrayFirst = new int[100];
            InputArrray(arrayFirst, totalElementFirst);
            OutputArray(arrayFirst, totalElementFirst);

            Console.Write("Nhap so phan tu cua mang thu hai :");
            int totalElementSecond = int.Parse(Console.ReadLine());
            int[] arraySecond = new int[100];
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