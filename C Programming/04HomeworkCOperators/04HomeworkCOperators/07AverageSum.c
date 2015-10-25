
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    double a,b,c;
    scanf("%lf %lf %lf",&a,&b,&c);
    double average = (a + b + c)/3;
    printf("%f",average);
    return (EXIT_SUCCESS);
}

