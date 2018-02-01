namespace Algorithm.MostFrequentNumbers.Interface
{
    public interface IMostFrequentNumber
    {
        /// <summary>
        /// Max element in array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        /// <returns></returns>
        int MaxElement(int[] array, int totalElement);

        /// <summary>
        /// Max element duplicate in array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="totalElement"></param>
        /// <returns></returns>
        int MaxElementDuplicate(int[] array, int totalElement);

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