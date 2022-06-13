using System;

namespace GitFlowTraining
{
    public class LinearSearchingAlgorithm : ISearchingAlgorithm
    {
        private uint iterationsCount;

        public T findElement<T>(T[] arr, T element) where T : IComparable<T>
        {
            T result = default(T);
            iterationsCount = 0;

            for (int i=0; i<arr.Length; i++)
            {
                iterationsCount++;
                if (element.Equals(arr[i]))
                {
                    return arr[i];
                }
            }

            return result;
        }

        public uint IterationCountForLastExecution()
        {
            return iterationsCount;
        }
    }
}
