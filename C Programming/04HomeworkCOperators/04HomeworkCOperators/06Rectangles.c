
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    double width, height;
    scanf("%lf %lf",&width,&height);
    double perimeter = 2 * width + 2 * height;
    double area = width * height;
    printf("Perimeter: %f\n",perimeter);
    printf("Area: %f\n",area);
    return (EXIT_SUCCESS);
}

