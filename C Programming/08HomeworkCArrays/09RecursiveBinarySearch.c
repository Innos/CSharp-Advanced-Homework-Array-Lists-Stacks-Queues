

#include <stdio.h>
#include <stdlib.h>
#include "BinarySearch.h"

// classes are exported into class files so i can reuse them if i need to later

int main(int argc, char** argv) {
    int size;
    scanf("%d", &size);
    int numbers[size];
    int i;
    for (i = 0; i < size; i++) {
        scanf("%d", &numbers[i]);
    }
    int element;
    scanf("%d", &element);
    //Quicksort(numbers,0,size-1);
    int index = BinarySearchRecursive(numbers,0,size-1,element);
    printf("%d", index);

    return (EXIT_SUCCESS);
}

