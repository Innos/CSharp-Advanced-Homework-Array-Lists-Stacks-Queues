
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int rows,cols;
    scanf("%d %d",&rows,&cols);
    int matrix1[rows][cols];
    int matrix2[rows][cols];
    int i,j;
    for(i=0;i<rows;i++){
        for(j=0;j<cols;j++){
            scanf("%d",&matrix1[i][j]);
        }
    }
    for(i=0;i<rows;i++){
        for(j=0;j<cols;j++){
            scanf("%d",&matrix2[i][j]);
            matrix2[i][j] = matrix1[i][j] + matrix2[i][j];
        }
    }
    printf("Sum:\n");
    for(i=0;i<rows;i++){
        for(j=0;j<cols;j++){
            printf("%d ",matrix2[i][j]);
        }
        printf("\n");
    }
    return (EXIT_SUCCESS);
}

