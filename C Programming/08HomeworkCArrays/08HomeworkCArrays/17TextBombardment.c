

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* ParseText();
void PadWithSpaces(char* text, int rows, int cols, int textlen);
long* ParseBombs(int* bombsLength);
void BlowRows(long * bombs, int rows, int cols,int bombLength,char matrix[][cols]);
void Print(int rows,int cols,int textlen, char matrix[][cols]);

void Print(int rows,int cols, int textlen,char matrix[][cols]){
    int row,col;
    for(row=0;row<rows;row++){
        for(col=0;col<cols;col++){
            if(row*cols + col == textlen){
                return;
            }
            printf("%c",matrix[row][col]);
        }
    }
}

void BlowRows(long * bombs, int rows, int cols, int bombsLength,char matrix[][cols]) {
    int bomb, row;
    for (bomb = 0; bomb < bombsLength; bomb++) {
        long bombValue = bombs[bomb];
        int hasExploded = 0;
        for (row = 0; row < rows; row++) {
            if (matrix[row][bombValue] == ' ' && hasExploded) {
                break;
            }
            matrix[row][bombValue] = ' ';
            hasExploded = 1;
        }
    }
}

long* ParseBombs(int* bombsLength) {
    char *bombline = NULL;
    size_t bLineSize = 0;
    getline(&bombline, &bLineSize, stdin);
    long *bombs = malloc(100*sizeof(long));
    int bLength = 0;
    char* bomb = strtok(bombline, " ");
    while (bomb != NULL) {
        bombs[bLength] = strtol(bomb, NULL, 10);
        bLength++;
        bomb = strtok(NULL, " ");
    }
    free(bombline);
    *bombsLength = bLength;
    return bombs;
}

void PadWithSpaces(char* text, int rows, int cols, int textlen) {
    int i;
    for (i = textlen; i < rows * cols; i++) {
        text[i] = ' ';
    }
}

char* ParseText() {
    char* text = NULL;
    size_t size = 0;
    int textlen = getline(&text, &size, stdin);
    if (text[textlen - 1] == '\n') {
        text[textlen - 1] = '\0';
    }
    return text;
}

//COMPILE FOR C99
int main(int argc, char** argv) {

    char* text = ParseText();
    int textlen = strlen(text);

    int cols;
    scanf("%d%*c", &cols);
    int rows = 0;

    // set rows
    if (textlen % cols > 0) {
        rows = textlen / cols + 1;
    } else {
        rows = textlen / cols;
    }

    PadWithSpaces(text, rows, cols, textlen);

    int bombsLength = 0;
    long* bombs = ParseBombs(&bombsLength);

    //fill matrix
    char matrix[rows][cols];

    int row, col;
    for (row = 0; row < rows; row++) {
        for (col = 0; col < cols; col++) {
            matrix[row][col] = text[row*cols + col];
        }
    }
    
    BlowRows(bombs,rows,cols,bombsLength,matrix);
    
    Print(rows,cols,textlen,matrix);
    
    free(text);
    free(bombs);
    return (EXIT_SUCCESS);
}

