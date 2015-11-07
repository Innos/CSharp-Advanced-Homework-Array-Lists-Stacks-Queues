

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char** argv) {
    unsigned long number;
    int start, end, bits;
    scanf("%lu %d %d %d", &number, &start, &end, &bits);

    if (start < 0 || end < 0 || bits < 0 || start + bits > 32 || end + bits > 32) {
        printf("out of range");
    } else if ((start < end && start + bits > end) || (end < start && end + bits > start)) {
        printf("overlapping");
    } else {
        unsigned long bitmask = (unsigned long)(pow(2,bits) - 1);
        unsigned long mask1 = (number >> start) & bitmask;
        unsigned long mask2 = (number >> end) & bitmask;
        unsigned long deleteMask1 = ~(bitmask << start);
        unsigned long deleteMask2 = ~(bitmask << end);

        number &= deleteMask1;
        number &= deleteMask2;

        number = number | (mask1 << end);
        number = number | (mask2 << start);

        printf("%lu", number);
    }
    return (EXIT_SUCCESS);
}

