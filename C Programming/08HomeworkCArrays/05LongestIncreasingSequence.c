

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int size;
    scanf("%d", &size);
    int numbers[size];
    int i;
    for (i = 0; i < size; i++) {
        scanf("%d", &numbers[i]);
    }
    int maxSequence = 1;
    int maxStart = 0;

    printf("Sequences:\n%d ", numbers[0]);
    int j, currentLength = 1;
    for (j = 1; j < size; j++) {
        if (numbers[j] > numbers[j - 1]) {
            printf("%d ", numbers[j]);
            currentLength++;
        } else {
            printf("\n%d ", numbers[j]);
            currentLength = 1;
        }
        if (currentLength > maxSequence) {
            maxSequence = currentLength;
            maxStart = j - (currentLength - 1);
        }
    }

    printf("\nLongest: ");
    int k;
    for (k = maxStart; k < maxStart + maxSequence; k++) {
        printf("%d ", numbers[k]);
    }

    return (EXIT_SUCCESS);
}

