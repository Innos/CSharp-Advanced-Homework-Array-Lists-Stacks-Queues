
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int rows,cols;
    scanf("%d %d",&rows,&cols);
    int matrix1[rows][cols];
    int matrix2[cols][rows];
    
    int i,j;
    for(i=0;i<rows;i++){
        for(j=0;j<cols;j++){
            scanf("%d",&matrix1[i][j]);
        }
    }
    for(i=0;i<cols;i++){
        for(j=0;j<rows;j++){
            scanf("%d",&matrix2[i][j]);
        }
    }
    int result[rows][rows];
    int k,l;

        for(j=0;j<rows;j++){
            for(k=0;k<rows;k++){
                int sum =0;
                for(l=0;l<cols;l++){
                    sum += matrix1[j][l] * matrix2[l][k];
                }
                result[j][k] = sum;
                printf("%d ",result[j][k]);
            }
            printf("\n");  
        }
        
    return (EXIT_SUCCESS);
}

