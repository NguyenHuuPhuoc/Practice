using Algorithm.Commons.Interface;
using System;

namespace Algorithm.Commons.Implement
{
    public abstract class Common : ICommon
    {
        /// <summary>
        /// Input
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        public void InputArrray(int[] array, int totalElement)
        {
            for (int i = 0; i < totalElement; i++)
            {
                Console.Write("a[" + i + "]=");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Output
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        public void OutputArray(int[] array, int totalElement)
        {
            Console.Write("Hien thi mang:");
            for (int i = 0; i < totalElement; i++)
                Console.Write(array[i] + " ");
            Console.Write("\n");
        }
    }
}