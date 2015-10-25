

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    long n;
    scanf("%li", &n);
    int factorOf5 = 0;
    while (n > 4) {
        factorOf5 = factorOf5 + (n / 5);
        n = n / 5;
    }
    printf("%d",factorOf5);
    return (EXIT_SUCCESS);
}

