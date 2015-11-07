
#include <stdio.h>
#include <stdlib.h>

void Print(char character, int times);

void Print(char character, int times) {
    int i;
    for (i = 0; i < times; i++) {
        printf("%c", character);
    }
}

int main(int argc, char** argv) {
    int size;
    scanf("%d", &size);
    int row;
    for (row = 0; row < size / 2; row++) {
        if (row == 0) {
            int sideSpace = (size - 1) / 2;
            Print('.', sideSpace);
            Print('*', 1);
            Print('.', sideSpace);
            printf("\n");
        } else {
            int midspace = (row * 2) - 1;
            int sideSpace = (size - 2 - midspace) / 2;
            Print('.',sideSpace);
            Print('*', 1);
            Print('.', midspace);
            Print('*', 1);
            Print('.',sideSpace);
            printf("\n");
        }
    }
    
    for (row = size/2; row >= 0; row--) {
        if (row == 0) {
            int sideSpace = (size - 1) / 2;
            Print('.', sideSpace);
            Print('*', 1);
            Print('.', sideSpace);
            printf("\n");
        } else {
            int midspace = (row * 2) - 1;
            int sideSpace = (size - 2 - midspace) / 2;
            Print('.',sideSpace);
            Print('*', 1);
            Print('.', midspace);
            Print('*', 1);
            Print('.',sideSpace);
            printf("\n");
        }
    }
    return (EXIT_SUCCESS);
}

