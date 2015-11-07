
#include <stdio.h>
#include <stdlib.h>
#include "Quicksort.h"

void Sort(int* numbers, size_t len,int size);


void Sort(int* numbers, size_t len,int size) {
    Quicksort(numbers, 0, len - 1);
}


int main(int argc, char** argv) {

    size_t size;
    scanf("%u", &size);
    int numbers[size];
    int i;
    for (i = 0; i < size; i++) {
        scanf("%d", &numbers[i]);
    }
    Sort(numbers, size,sizeof(numbers));
    
    int j;
    for(j = 0;j<size;j++){
        printf("%d ",numbers[j]);
    }

    return (EXIT_SUCCESS);
}

