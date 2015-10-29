

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int size = 3;
    int vector1[size];
    int vector2[size];
    int determinants[size];

    int i;
    for (i = 0; i < size; i++) {
        scanf("%d", &vector1[i]);
    }
    for (i = 0; i < size; i++) {
        scanf("%d", &vector2[i]);
    }
    for (i = 0; i < size; i++) {
        determinants[i] = (vector1[(i + 1) % 3] * vector2[(i + 2) % 3]) - (vector1[(i + 2) % 3] * vector2[(i + 1) % 3]);
    }
    printf("[");
    for(i=0;i<size;i++){
        printf("%d ",determinants[i]);
    }
    printf("]");
    return (EXIT_SUCCESS);
}

