
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(int argc, char** argv) {
    char binaryString[65];
    memset(binaryString, '0', sizeof binaryString);
    long n;
    scanf("%li", &n);
    if (n == 0) {
        printf("0");
    } else {
        long bit = log2(n) + 1;
        binaryString[bit] = '\0';
        bit--;

        while (n > 0) {
            binaryString[bit] = (n % 2 == 1) ? '1' : '0';
            n /= 2;
            bit--;
        }
        printf("%s", binaryString);
    }
    return (EXIT_SUCCESS);
}

