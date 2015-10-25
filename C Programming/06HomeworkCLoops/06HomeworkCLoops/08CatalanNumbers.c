

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int n;
    scanf("%d", &n);
    unsigned long long result = 1;
    int j;
    int factorialN = 1;
    int roof = 2 * n;
    for (j = roof; j > n; j--) {
        result = (result * j) / factorialN;
        factorialN++;
    }
    result = result / factorialN;

    printf("%llu", result);
    return (EXIT_SUCCESS);
}

