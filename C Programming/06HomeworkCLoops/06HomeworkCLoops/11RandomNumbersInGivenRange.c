

#include <stdio.h>
#include <stdlib.h>
#include <time.h>



int main(int argc, char** argv) {
    int n,min,max;
    scanf("%d %d %d",&n,&min,&max);
    srand(time(NULL));
    int i;
    for(i = 0;i<n;i++){
        int random = (rand() % (max + 1 - min) + min); 
        printf("%d ",random);
    }
    return (EXIT_SUCCESS);
}

