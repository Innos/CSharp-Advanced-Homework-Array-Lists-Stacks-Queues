

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    long num,position;
    scanf("%li %li",&num,&position);
    long mask = ~((long)1 << position);
    num = num & mask;
    printf("%li",num);
    return (EXIT_SUCCESS);
}

