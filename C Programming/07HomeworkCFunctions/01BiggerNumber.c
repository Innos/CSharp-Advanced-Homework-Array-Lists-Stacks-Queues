
#include <stdio.h>
#include <stdlib.h>

int get_max(int a,int b);

int get_max(int a, int b){
    if(a > b){
        return a;
    }
    return b;
}

int main(int argc, char** argv) {
    int a,b;
    scanf("%d %d",&a,&b);
    printf("%d",get_max(a,b));
    return (EXIT_SUCCESS);
}

