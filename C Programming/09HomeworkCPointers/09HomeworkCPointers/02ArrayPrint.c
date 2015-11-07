

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {

    int array[] = {1,2,3,4,5};
    int size = sizeof(array) / sizeof(array[0]);
    int i;
    for(i=0;i<size;i++){
        printf("%d ",*(array + i));
    }
    return (EXIT_SUCCESS);
}

