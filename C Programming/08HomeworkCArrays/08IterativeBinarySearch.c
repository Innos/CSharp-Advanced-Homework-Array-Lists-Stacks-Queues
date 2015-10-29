

#include <stdio.h>
#include <stdlib.h>
#include "BinarySearch.h"
#include "Quicksort.h"


int main(int argc, char** argv) {
    int size;
    scanf("%d",&size);
    int numbers[size];
    int i;
    for(i=0;i<size;i++){
        scanf("%d",&numbers[i]);
    }
    int element;
    scanf("%d",&element);
    //Quicksort(numbers,0,size-1);
    int index = BinarySearchIterative(numbers,size,element);
    printf("%d",index);
    
    return (EXIT_SUCCESS);
}

