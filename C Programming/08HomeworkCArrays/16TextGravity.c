
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int cols;
    scanf("%d%*c", &cols);
    char* text = NULL;
    size_t size = 0;
    int textlen = getline(&text, &size, stdin);
    if(text[textlen-1] == '\n'){
        textlen = textlen - 1;
    } 

    int rows = 0;
    if (textlen % cols > 0) {
        rows = textlen / cols + 1;
    } else {
        rows = textlen / cols;
    }
    int i;
    for (i = textlen; i < rows * cols; i++) {
        text[i] = ' ';
    }
    char matrix[rows][cols];
    int j;
    for (i = 0; i < rows; i++) {
        for (j = 0; j < cols; j++) {
            matrix[i][j] = text[i * cols + j];
        }
    }

    for (i = rows - 1; i >= 1; i--) {
        for (j = cols - 1; j >= 0; j--) {
            if (matrix[i][j] == ' ') {
                int above = i - 1;
                while (above > 0 && matrix[above][j] == ' ') {
                    above--;
                }
                char temp = matrix[i][j];
                matrix[i][j] = matrix[above][j];
                matrix[above][j] = temp;
            }
        }
    }

    for (i = 0; i < rows; i++) {
        printf("|");
        for (j = 0; j < cols; j++) {
            printf("%c", matrix[i][j]);
        }
        printf("|\n");
    }
    return (EXIT_SUCCESS);
}

