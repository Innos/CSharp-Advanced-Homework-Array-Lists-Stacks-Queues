

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    double sideA, sideB, height;
    scanf("%lf %lf %lf", &sideA, &sideB, &height);
    double area = ((sideA + sideB) / 2) * height;
    printf("%f",area);
    return (EXIT_SUCCESS);
}

