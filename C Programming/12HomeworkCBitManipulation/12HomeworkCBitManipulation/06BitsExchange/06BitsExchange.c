

#include <stdio.h>
#include <stdlib.h>

const int position1 = 3;
const int position2 = 24;

int main(int argc, char** argv) {
    unsigned long number;
    scanf("%lu",&number);
    
    unsigned long mask1 = (number >> position1) & 7;
    unsigned long mask2 = (number >> position2) & 7;
    unsigned long deleteMask1 = ~(7 << position1);
    unsigned long deleteMask2 = ~(7 << position2);
    
    number &= deleteMask1;
    number &= deleteMask2;
    
    number = number | (mask1 << position2);
    number = number | (mask2 << position1);
    
    printf("%lu",number);
    return (EXIT_SUCCESS);
}

