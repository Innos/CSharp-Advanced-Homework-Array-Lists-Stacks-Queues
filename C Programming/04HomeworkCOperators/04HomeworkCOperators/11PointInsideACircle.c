
#include <stdio.h>
#include <stdlib.h>

#define RADIUS 2

int main(int argc, char** argv) {
    double x,y;
    scanf("%lf %lf",&x,&y);
    if(x*x + y*y <= RADIUS * RADIUS){
        printf("Yes");
    }
    else{
        printf("No");
    }
    return (EXIT_SUCCESS);
}

