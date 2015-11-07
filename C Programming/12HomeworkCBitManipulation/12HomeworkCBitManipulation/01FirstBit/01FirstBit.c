

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int number;
    scanf("%d",&number);
    int firstBit = (number >> 1) & 1;
    printf("%d",firstBit);
    return (EXIT_SUCCESS);
}

