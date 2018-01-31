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
        public Boolean CheckElementDuplicate(int[] array, int totalElement)
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
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        public void BusinessLogic(int[] array, int totalElement)
        {
            if (CheckElementDuplicate(array, totalElement))
            {
                int max = array[0];
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
                int max = array[0], result = 0;
                for (int i = 1; i < totalElement; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        result = i;
                    }
                }
                Console.Write("Ouput: {0}", result);
            }
        }

        /// <summary>
        /// Main of MostFrequentNumber
        /// </summary>
        public void MainMostFrequentNumber()
        {
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