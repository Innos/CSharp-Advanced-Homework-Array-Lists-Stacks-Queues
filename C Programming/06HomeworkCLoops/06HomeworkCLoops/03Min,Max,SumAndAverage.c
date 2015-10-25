
#include <stdio.h>
#include <stdlib.h>
#include <limits.h>

double Min(int numbers[], int size);
double Max(int numbers[], int size);
double Sum(int numbers[], int size);
double Average(int numbers[], int size);

int main(int argc, char** argv) {
    int n;
    scanf("%d", &n);
    int numbers[n];

    int i;
    for (i = 0; i < n; i++) {
        scanf("%d", &numbers[i]);
    }
    printf("min = %.2f\n",Min(numbers,n));
    printf("max = %.2f\n",Max(numbers,n));
    printf("sum = %.2f\n",Sum(numbers,n));
    printf("average = %.2f\n",Average(numbers,n));
    return (EXIT_SUCCESS);
}

double Min(int numbers[], int size) {
    double min = INT_MAX;
    int i;
    for (i = 0; i < size; i++) {
        if (numbers[i] < min) {
            min = numbers[i];
        }
    }
    return min;
}

double Max(int numbers[], int size) {
    double max = INT_MIN;
    int i;
    for (i = 0; i < size; i++) {
        if (numbers[i] > max) {
            max = numbers[i];
        }
    }
    return max;
}

double Sum(int numbers[], int size) {
    double sum = 0;
    int i;
    for (i = 0; i < size; i++) {
        sum += numbers[i];
    }
    return sum;
}

double Average(int numbers[], int size) {
    double average = 0;
    average = Sum(numbers, size);
    average = average / size;
    return average;
}