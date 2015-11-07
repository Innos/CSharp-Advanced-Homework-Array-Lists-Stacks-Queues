
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int loops, step;
    scanf("%d %d", &loops, &step);

    int i, currentBit = 0;
    for (i = 0; i < loops; i++) {
        int num;
        scanf("%d", &num);
        int bit;
        for (bit = 7; bit >= 0; bit--) {
            if ((currentBit > 0 && step == 1) || currentBit % step == 1) {
                int mask = 1 << bit;
                num = num | mask;
            }
            currentBit++;
        }
        printf("%d\n",num);
    }
    return (EXIT_SUCCESS);
}

