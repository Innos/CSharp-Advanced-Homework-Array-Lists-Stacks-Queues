
#include <stdio.h>
#include <stdlib.h>


int main() {
    
    long double a = 34.567839023;
    float b = 12.345f;
    double c = 8923.1234857;
    float d = 3456.091f;
    
    printf("%.11llf\n%f\n%.11f\n%f",a,b,c,d);
    return (EXIT_SUCCESS);
}

