

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    long num,position;
    scanf("%li %li",&num,&position);
    int bit = (num >> position) & 1;
    printf("%d",bit);
    return (EXIT_SUCCESS);
}

