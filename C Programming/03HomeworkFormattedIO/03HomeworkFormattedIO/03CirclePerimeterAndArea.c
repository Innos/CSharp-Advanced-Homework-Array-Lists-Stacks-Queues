

#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int main(int argc, char** argv) {
    double radius;
    scanf("%lf",&radius);
    double area = radius * radius * M_PI;
    double perimeter = 2 * M_PI * radius;
    printf("Area: %.2f\n",area);
    printf("Perimeter: %.2f\n",perimeter);
    return (EXIT_SUCCESS);
}

