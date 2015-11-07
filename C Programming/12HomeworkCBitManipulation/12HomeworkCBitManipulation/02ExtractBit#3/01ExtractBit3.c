

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {

    int position = 3;
    unsigned int num;
    scanf("%u",&num);
    int thirdBit = (num >> position) & 1;
    printf("%d",thirdBit);
    return (EXIT_SUCCESS);
}

