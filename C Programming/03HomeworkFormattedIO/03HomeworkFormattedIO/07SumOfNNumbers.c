
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int n;
    scanf("%d",&n);
    long double sum  = 0;
    int i;
    for(i = 0; i<n;i++){
        double temp;
        scanf("%lf",&temp);
        sum += temp;
    }
    printf("%llf",sum);
    return (EXIT_SUCCESS);
}

