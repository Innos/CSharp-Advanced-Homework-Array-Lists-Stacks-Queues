
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

static const double eps = 0.000001;

int main() {
    double a,b;
    scanf("%lf",&a);
    scanf("%lf",&b);

    printf("%s",fabs(a-b) < eps ? "True" : "False");
    return (EXIT_SUCCESS);
}

