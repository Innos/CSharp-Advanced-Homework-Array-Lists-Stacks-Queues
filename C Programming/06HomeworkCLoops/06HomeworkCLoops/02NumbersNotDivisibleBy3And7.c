
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int n;
    scanf("%d",&n);
    int i;
    for(i = 1; i<=n;i++){
        if(i % 3 == 0 || i % 7 == 0){
            continue;
        }
        printf("%d ",i);
    }
    return (EXIT_SUCCESS);
}

