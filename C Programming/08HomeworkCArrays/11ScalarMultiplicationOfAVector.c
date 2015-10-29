
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int size, scalar;
    scanf("%d %d", &size, &scalar);
    int vector[size];
    int i;
    for (i = 0; i < size; i++) {
        scanf("%d", &vector[i]);
        vector[i] = vector[i] * scalar;
    }

    for (i = 0; i < size; i++) {
        printf("%d ", vector[i]);
    }

    return (EXIT_SUCCESS);
}

