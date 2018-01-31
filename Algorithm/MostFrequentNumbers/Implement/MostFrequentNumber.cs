using Algorithm.Commons.Implement;
using Algorithm.MostFrequentNumbers.Interface;
using System;

namespace Algorithm.MostFrequentNumbers.Implement
{
    public class MostFrequentNumber : Common, IMostFrequentNumber
    {
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
                for (int i = 0; i < totalElement; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                Console.Write("Ouput: {0}", max);
            }
            else
            {
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
                Console.Write("Ouput: {0}", max);
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

            int[] array = new int[100];
            InputArrray(array, totalElement);
            OutputArray(array, totalElement);

            BusinessLogic(array, totalElement);

            Console.ReadKey();
        }
    }
}