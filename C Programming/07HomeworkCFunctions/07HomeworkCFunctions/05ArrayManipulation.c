
#include <stdio.h>
#include <stdlib.h>
#include "ArrayManipulation.h"

int main(int argc, char** argv) {

    int array[] = {1, 3, -1, -3, 10};
    size_t size = (sizeof (array) / sizeof (array[0]));
    int min = arr_min(array, size);
    int max = arr_max(array, size);
    long sum = arr_sum(array, size);
    double average = arr_average(array, size);


    printf("Min: %d\nMax: %d\nSum: %li\nAverage: %f\n", min, max, sum, average);

    int array2[] = {-10, -20, -30};
    size_t size2 = (sizeof (array2) / sizeof (array2[0]));
    int * mergedArray = arr_merge(array, size, array2, size2);
    
    int i;
    for (i = 0; i < size + size2; i++) {
        printf("%d ", mergedArray[i]);
    }
    printf("\n");

    arr_clear(array, size);
    int j;
    for (j = 0; j < size; j++) {
        printf("%d ", array[j]);
    }
    printf("\n");

    return (EXIT_SUCCESS);
}

