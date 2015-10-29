
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

double min(double* numbers, int size);
double max(double* numbers, int size);
double average(double* numbers, int size);
double sum(double* numbers, int size);

double min(double*numbers, int size) {
    double min = numbers[0];
    int i;
    for (i = 1; i < size; i++) {
        if (numbers[i] < min) {
            min = numbers[i];
        }
    }
    return min;
}

double max(double* numbers, int size) {
    double max = numbers[0];
    int i;
    for (i = 1; i < size; i++) {
        if (numbers[i] > max) {
            max = numbers[i];
        }
    }
    return max;
}

double average(double* numbers, int size) {
    double average = 0;
    int i;
    for (i = 0; i < size; i++) {
        average += numbers[i];
    }
    average = average / size;
    return average;
}

double sum(double*numbers, int size) {
    double sum = 0;
    int i;
    for (i = 0; i < size; i++) {
        sum += numbers[i];
    }
    return sum;
}

int main(int argc, char** argv) {
    int size;
    scanf("%d", &size);
    double array[size];
    double doubles[size];
    double wholes[size];
    int i, sizeWhole = 0, sizeDoubles = 0;
    for (i = 0; i < size; i++) {
        scanf("%lf", &array[i]);
        if (fmod(array[i], 1) > 0) {
            doubles[sizeDoubles] = array[i];
            sizeDoubles++;
        } else {
            wholes[sizeWhole] = array[i];
            sizeWhole++;
        }
    }
    printf("[");
    int k;
    for (k = 0; k < sizeDoubles; k++) {
        printf("%.3f ", doubles[k]);
    }
    printf("] -> min: %.3f, max: %.3f, sum: %.3f, average: %.3f\n",
            min(doubles, sizeDoubles),
            max(doubles, sizeDoubles),
            sum(doubles, sizeDoubles),
            average(doubles, sizeDoubles));

    printf("[");
    int j;
    for (j = 0; j < sizeWhole; j++) {
        printf("%li ", (long)wholes[j]);
    }
    printf("] -> min: %li, max: %li, sum: %li, average: %f\n",
            (long)min(wholes, sizeWhole),
            (long)max(wholes, sizeWhole),
            (long)sum(wholes, sizeWhole),
            average(wholes, sizeWhole));


    return (EXIT_SUCCESS);
}

