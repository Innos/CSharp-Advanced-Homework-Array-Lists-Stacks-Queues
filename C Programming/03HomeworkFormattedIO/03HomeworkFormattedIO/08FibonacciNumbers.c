

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int n;
    scanf("%d",&n);
    int fibonacci[n];
    fibonacci[0] = 0;
    fibonacci[1] = 1;
    int i;
    for(i = 0; i<n;i++){
        if(i>1){
            fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
        }
        printf("%d ",fibonacci[i]);
    }
    return (EXIT_SUCCESS);
}

