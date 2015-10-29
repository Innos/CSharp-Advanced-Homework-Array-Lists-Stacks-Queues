

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int size;
    scanf("%d",&size);
    int matrix[size][size];
    int i,j;
    for(i=0;i<size;i++){
        for(j=0;j<size;j++){
            scanf("%d",&matrix[i][j]);  
        }
    }
    
    for(i=0;i<size;i++){
        for(j=0;j<=i;j++){
            printf("%d ",matrix[i][j]);
        }
        printf("\n");
    }
    return (EXIT_SUCCESS);
}

