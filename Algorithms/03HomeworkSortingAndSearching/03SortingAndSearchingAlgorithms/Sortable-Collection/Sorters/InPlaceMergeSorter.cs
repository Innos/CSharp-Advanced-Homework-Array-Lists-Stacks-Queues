namespace Sortable_Collection.Sorters
{
    using System;
    using System.Collections.Generic;

    using Sortable_Collection.Contracts;

    public class InPlaceMergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(List<T> collection)
        {
            // important to note the implementation requires input in the form  -> the collection, the first element and the length of the collection (NOT the last element) 
            this.InPlaceMergeSort(collection, 0, collection.Count);
        }

        private static void Swap(List<T> collection, int a, int b)
        {
            T temp = collection[a];
            collection[a] = collection[b];
            collection[b] = temp;
        }

        private void InPlaceMergeSort(List<T> collection, int start, int end)
        {
            int mid;
            int workingStart1;
            int workingStart2;
            if (end - start > 1)
            {
                mid = start + ((end - start) / 2);
                workingStart2 = start + end - mid;

                // the last half contains sorted elements
                this.SortWorkingArea(collection, start, mid, workingStart2);
                while (workingStart2 - start > 2)
                {
                    workingStart1 = workingStart2;
                    workingStart2 = start + ((workingStart1 - start + 1) / 2);

                    // the first half of the previous working area contains sorted elements
                    this.SortWorkingArea(collection, workingStart2, workingStart1, start);
                    this.Merge(collection, start, start + workingStart1 - workingStart2, workingStart1, end, workingStart2);
                }

                for (workingStart1 = workingStart2; workingStart1 > start; workingStart1--)
                {
                    for (mid = workingStart1; mid < end && collection[mid].CompareTo(collection[mid - 1]) < 0; mid++)
                    {
                        Swap(collection, mid, mid - 1);
                    }
                }
            }
        }

        // merge 2 sorted subarrays in place
        private void Merge(List<T> collection, int start1, int end1, int start2, int end2, int workingStart)
        {
            while (start1 < end1 && start2 < end2)
            {
                Swap(collection, workingStart++, collection[start1].CompareTo(collection[start2]) <= 0 ? start1++ : start2++);
            }

            while (start1 < end1)
            {
                Swap(collection, workingStart++, start1++);
            }

            while (start2 < end2)
            {
                Swap(collection, workingStart++, start2++);
            }
        }

        // sorts a subarray and exchanges it with the working area
        private void SortWorkingArea(List<T> collection, int start, int end, int workingStart)
        {
            if (end - start > 1)
            {
                int mid = start + ((end - start) / 2);
                this.InPlaceMergeSort(collection, start, mid);
                this.InPlaceMergeSort(collection, mid, end);
                this.Merge(collection, start, mid, mid, end, workingStart);
            }
            else
            {
                while (start < end)
                {
                    Swap(collection, start++, workingStart++);
                }
            }
        }
    }
}
