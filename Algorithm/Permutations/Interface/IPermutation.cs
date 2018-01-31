using System;

namespace Algorithm.Permutations.Interface
{
    public interface IPermutation
    {
        /// <summary>
        /// Business
        /// </summary>
        /// <param name="arrayFirst"></param>
        /// <param name="arraySecond"></param>
        /// <returns></returns>
        bool BusinessLogic(int[] arrayFirst, int[] arraySecond);

        /// <summary>
        /// Main of Permutation
        /// </summary>
        void MainPermutation();
    }
}