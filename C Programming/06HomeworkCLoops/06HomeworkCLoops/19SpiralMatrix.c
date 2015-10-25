
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int n;
    scanf("%d", &n);
    int number = 1;
    int matrix[n][n];
    int roof = n*n;
    int row = 0;
    int col = 0;
    int maxRow = n - 1;
    int maxCol = n - 1;
    while (number <= roof){

        //right
        int i;
        for (i = col; i <= maxCol; i++) {
            matrix[row][i] = number;
            number++;
        }
        row++;

        //down
        for (i = row; i <= maxRow; i++) {
            matrix[i][maxCol] = number;
            number++;
        }
        maxCol--;

        //left
        for (i = maxCol; i >= col; i--) {
            matrix[maxRow][i] = number;
            number++;
        }
        maxRow--;

        //up
        for (i = maxRow; i >= row; i--) {
            matrix[i][col] = number;
            number++;
        }
        col++;
    } 
    int r1, c1;
    for (r1 = 0; r1 < n; r1++) {
        for (c1 = 0; c1 < n; c1++) {
            printf("%3d", matrix[r1][c1]);
        }
        printf("\n");
    }
    return (EXIT_SUCCESS);
}

