namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            var tempArray = new T[collection.Count];
            this.MergeSort(collection, tempArray, 0, collection.Count - 1);
        }

        private void MergeSort(List<T> collection, T[] temporaryArray, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                this.MergeSort(collection, temporaryArray, start, mid);
                this.MergeSort(collection, temporaryArray, mid + 1, end);

                this.Merge(collection, temporaryArray, start, mid, end);
            }
        }

        private void Merge(List<T> collection, T[] temporaryArray, int start, int mid, int end)
        {
            int leftStart = start;
            int rightStart = mid + 1;
            int tempIndex = 0;

            while (leftStart <= mid && rightStart <= end)
            {
                if (collection[leftStart].CompareTo(collection[rightStart]) <= 0)
                {
                    temporaryArray[tempIndex++] = collection[leftStart++];
                }
                else
                {
                    temporaryArray[tempIndex++] = collection[rightStart++];
                }
            }

            while (leftStart <= mid)
            {
                temporaryArray[tempIndex++] = collection[leftStart++];
            }

            while (rightStart <= end)
            {
                temporaryArray[tempIndex++] = collection[rightStart++];
            }

            leftStart = start;
            tempIndex = 0;

            while (tempIndex < temporaryArray.Length && leftStart <= end)
            {
                collection[leftStart] = temporaryArray[tempIndex];
                tempIndex++;
                leftStart++;
            }
        }
    }
}
