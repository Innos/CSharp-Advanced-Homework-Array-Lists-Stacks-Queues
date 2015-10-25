
#include <stdio.h>
#include <stdlib.h>

int Multiply(int array[], int length, int number);

int main() {
    int n, k;
    scanf("%d %d", &n, &k);
    int remainder = n - k;
    //ensure k is smaller than the remainder
    if (remainder < k) {
        //swap
        int temp = k;
        k = remainder;
        remainder = temp;
    }
    unsigned long long factorialK = 1;
    unsigned long long result = 1;
    int j;
    for (j = n; j > remainder; j--) {
        if (factorialK <= k) {
            result = (result * j) / factorialK;
            factorialK++;
        } else {
            result *= j;
        }
    }
    printf("%llu", result);
    return 0;
}

//for calculating large factorials in an array, useless here cause cant divide

int Multiply(int array[], int length, int number) {
    int temp = 0;
    int i;
    for (i = 0; i < length; i++) {
        int x = array[i] * number + temp;
        array[i] = x % 10;
        temp = x / 10;
    }

    while (temp > 0) {
        array[length] = temp % 10;
        temp = temp / 10;
        length++;
    }
    return length;
}

