#include "ArrayManipulation.h"

int arr_min(int* array, size_t size) {
    int min = array[0];
    int i;
    for (i = 0; i < size; i++) {
        if (array[i] < min) {
            min = array[i];
        }
    }
    return min;
}

int arr_max(int* array, size_t size) {
    int max = array[0];
    int i;
    for (i = 0; i < size; i++) {
        if (array[i] > max) {
            max = array[i];
        }
    }
    return max;
}

void arr_clear(int* array, size_t size) {
    int i;
    for (i = 0; i < size; i++) {
        array[i] = 0;
    }
}

double arr_average(int* array, size_t size) {
    double average = 0;
    int i;
    for (i = 0; i < size; i++) {
        average += array[i];
    }
    average = average / size;
    return average;
}

long arr_sum(int * array, size_t size) {
    long sum = 0;
    int i;
    for (i = 0; i < size; i++) {
        sum += array[i];
    }
    return sum;
}

bool arr_contains(int* array, size_t size, int element) {
    int i;
    for (i = 0; i < size; i++) {
        if (array[i] == element) {
            return true;
        }
    }
    return false;
}

int* arr_merge(int* array1, size_t size1, int *array2, size_t size2) {
    int* array = malloc((size1 + size2) * sizeof (int));
    int arrayIndex = 0;
    int i, j;
    for (i = 0; i < size1; i++) {
        array[arrayIndex] = array1[i];
        arrayIndex++;
    }
    for (j = 0; j < size2; j++) {
        array[arrayIndex] = array2[j];
        arrayIndex++;
    }
    return array;
}