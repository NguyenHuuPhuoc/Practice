using System;

namespace Algorithm.MostFrequentNumbers.Interface
{
    public interface IMostFrequentNumber
    {
        /// <summary>
        /// CheckElementDuplicate: check element duplicate in array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        /// <returns></returns>
        bool CheckElementDuplicate(int[] array, int totalElement);

        /// <summary>
        /// Business
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        void BusinessLogic(int[] array, int totalElement);

        /// <summary>
        /// Main of MostFrequentNumber
        /// </summary>
        void MainMostFrequentNumber();
    }
}