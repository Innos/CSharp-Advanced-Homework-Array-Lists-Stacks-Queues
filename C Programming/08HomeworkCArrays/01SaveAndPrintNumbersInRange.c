
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    size_t size;
    scanf("%d",&size);
    int numbers[size];
    int i;
    for(i=0;i<size;i++){
        scanf("%d",&numbers[i]);
        printf("%d ",numbers[i]);
    }
    return (EXIT_SUCCESS);
}

