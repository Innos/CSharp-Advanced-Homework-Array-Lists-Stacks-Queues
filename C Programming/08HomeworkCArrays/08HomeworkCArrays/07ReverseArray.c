
#include <stdio.h>
#include <stdlib.h>
#include "ReverseIntArray.h"


int main(int argc, char** argv) {
    int size;
    scanf("%d",&size);
    int numbers[size];
    int i;
    for(i=0;i<size;i++){
        scanf("%d",&numbers[i]);
    }
    
    ReverseIntArray(numbers,size);
    
    for(i=0;i<size;i++){
        printf("%d ",numbers[i]);
    }
    
    return (EXIT_SUCCESS);
}

