

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {

    int rows, cols, k;
    scanf("%d %d", &rows, &cols);
    char i, j;
    for (i = 'a'; i < 'a' + rows; i++) {
        for (j = i; j < i + cols; j++) {
            printf("%c%c%c ", i, j, i);
        }
        printf("\n");
    }
    return (EXIT_SUCCESS);
}

