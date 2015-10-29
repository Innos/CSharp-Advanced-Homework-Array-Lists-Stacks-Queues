
#include <stdio.h>
#include <stdlib.h>
#include "Quicksort.h"


int main(int argc, char** argv) {
    int size1,size2;
    scanf("%d %d",&size1,&size2);
    int size = size1 + size2;
    int numbers[size];
    int i;
    for(i=0;i<size;i++){
        scanf("%d",&numbers[i]);
    }
    Quicksort(numbers,0,size-1);
    int uniqueNumbers[size];
    int counter = 1;
    uniqueNumbers[0] = numbers[0];
    printf("%d ",uniqueNumbers[0]);
    int j;
    for(j=1;j<size;j++){
        if(numbers[j] != numbers[j-1]){
            uniqueNumbers[counter] = numbers[j];
            printf("%d ",uniqueNumbers[counter]);
            counter++;
        }
    }
    return (EXIT_SUCCESS);
}

