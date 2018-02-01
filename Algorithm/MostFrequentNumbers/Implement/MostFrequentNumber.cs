using Algorithm.Commons.Implement;
using Algorithm.MostFrequentNumbers.Interface;
using System;

namespace Algorithm.MostFrequentNumbers.Implement
{
    public class MostFrequentNumber : Common, IMostFrequentNumber
    {
        private int max;

        /// <summary>
        /// CheckElementDuplicate: check element duplicate in array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        /// <returns></returns>
        public bool CheckElementDuplicate(int[] array, int totalElement)
        {
            for (int i = 0; i < totalElement; i++)
            {
                for (int j = i + 1; j < totalElement; j++)
                {
                    if (array[i] == array[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Max element in array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        /// <returns></returns>
        public int MaxElement(int[] array, int totalElement)
        {
            max = array[0];
            for (int i = 0; i < totalElement; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Max element duplicate in array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        /// <returns></returns>
        public int MaxElementDuplicate(int[] array, int totalElement)
        {
            max = array[0];
            for (int i = 1; i < totalElement; i++)
            {
                for (int j = i + 1; j < totalElement; j++)
                {
                    if (array[i] == array[j])
                    {
                        if (array[i] > max)
                        {
                            max = array[i];
                        }
                    }
                }
            }
            return max;
        }

        /// <summary>
        /// Business
        /// if(CheckElementDuplicate ==true)
        /// {
        ///     Output: max element duplicate in array
        /// }
        /// else
        /// {
        ///     Output: max element in array
        /// }
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        public void BusinessLogic(int[] array, int totalElement)
        {
            int max = array[0];

            if (CheckElementDuplicate(array, totalElement))
            {
                Console.Write("Ouput: {0}", MaxElement(array, totalElement));
            }
            else
            {
                Console.Write("Ouput: {0}", MaxElementDuplicate(array, totalElement));
            }
        }

        /// <summary>
        /// Main of MostFrequentNumber
        /// </summary>
        public void MainMostFrequentNumber()
        {
            Console.Write("\t");
            Console.Write("******Question 2******\n");
            Console.Write("Nhap so phan tu cua mang: ");
            int totalElement = int.Parse(Console.ReadLine());

            int[] array = new int[totalElement];
            InputArrray(array, totalElement);
            OutputArray(array, totalElement);

            BusinessLogic(array, totalElement);

            Console.ReadKey();
        }
    }
}