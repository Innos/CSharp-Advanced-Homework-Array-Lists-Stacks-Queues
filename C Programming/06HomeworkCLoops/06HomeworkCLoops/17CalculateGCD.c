
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int a,b;
    scanf("%d %d",&a,&b);
    if(b>a){
        //swap
        int temp = a;
        a = b;
        b = temp;
    }
    while(a % b != 0){
        int temp = a % b;
        a = b;
        b = temp;
    }
    printf("GCD = %d",b);
    return (EXIT_SUCCESS);
}

