

#include <stdio.h>
#include <stdlib.h>
#include <math.h>


int main(int argc, char** argv) {
    double a,b,c;
    scanf("%lf %lf %lf",&a,&b,&c);
    double max = fmax(fmax(a,b),c);
    printf("%f",max);
    return (EXIT_SUCCESS);
}

