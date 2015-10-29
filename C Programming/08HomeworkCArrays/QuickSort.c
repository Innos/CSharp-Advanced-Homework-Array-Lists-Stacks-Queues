
#include "Quicksort.h"

void Quicksort(int * numbers, int start, int end) {
    if (start < end) {
        int partition = Partition(numbers, start, end);
        Quicksort(numbers, 0, partition);
        Quicksort(numbers, partition + 1, end);
    }
}

void QuicksortLong(long * numbers, int start, int end) {
    if (start < end) {
        int partition = PartitionLong(numbers, start, end);
        QuicksortLong(numbers, 0, partition);
        QuicksortLong(numbers, partition + 1, end);
    }
}

int Partition(int * numbers, int start, int end) {
    int midIndex = (start + end) / 2;
    int pivot = numbers[midIndex];
    int low = start - 1;
    int high = end + 1;

    while (1) {
        do {
            low += 1;
        } while (numbers[low] < pivot);
        do {
            high -= 1;
        } while (numbers[high] > pivot);
        
        if(low < high){
            Swap(numbers,low,high);
        }
        else{
            return high;
        }
    }
}

int PartitionLong(long * numbers, int start, int end) {
    int midIndex = (start + end) / 2;
    long pivot = numbers[midIndex];
    int low = start - 1;
    int high = end + 1;

    while (1) {
        do {
            low += 1;
        } while (numbers[low] < pivot);
        do {
            high -= 1;
        } while (numbers[high] > pivot);
        
        if(low < high){
            SwapLong(numbers,low,high);
        }
        else{
            return high;
        }
    }
}

void SwapLong(long* numbers, int indexA, int indexB){
    int temp = numbers[indexA];
    numbers[indexA] = numbers[indexB];
    numbers[indexB]  = temp;
}

void Swap(int* numbers, int indexA, int indexB){
    long temp = numbers[indexA];
    numbers[indexA] = numbers[indexB];
    numbers[indexB]  = temp;
}