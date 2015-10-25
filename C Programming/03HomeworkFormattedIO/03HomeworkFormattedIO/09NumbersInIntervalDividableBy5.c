

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int start,end;
    int numbers = 0;
    scanf("%d",&start);
    scanf("%d",&end);
    int i;
    for (i = start;i<=end;i++){
        if(i % 5 == 0){
            numbers++;
            printf("%d ",i);
        }
    }
    printf("\nNumbers ammount: %d\n",numbers);
    return (EXIT_SUCCESS);
}

