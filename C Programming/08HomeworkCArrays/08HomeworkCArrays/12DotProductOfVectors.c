

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int size;
    scanf("%d",&size);
    int vector1[size];
    int vector2[size];
    int i;
    for(i=0;i<size;i++){
        scanf("%d",&vector1[i]);
    }
    int sum = 0;
    for(i=0;i<size;i++){
        scanf("%d",&vector2[i]);
        sum += vector2[i] * vector1[i];
    }
    printf("Sum: %d",sum);
    return (EXIT_SUCCESS);
}

