
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int a;
    scanf("%d",&a);
    if(a % 9 == 0 || a % 11 == 0 || a % 13 == 0){
        printf("True");
    }
    else{
        printf("False");
    }
    return (EXIT_SUCCESS);
}

