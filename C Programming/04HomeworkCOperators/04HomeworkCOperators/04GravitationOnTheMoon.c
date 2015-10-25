

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    double weight;
    scanf("%lf",&weight);
    double moonWeight = weight * 0.17;
    printf("%f",moonWeight);
    return (EXIT_SUCCESS);
}

