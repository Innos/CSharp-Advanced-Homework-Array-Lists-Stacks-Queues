
#include <stdio.h>
#include <stdlib.h>

static const double RADIUS = 1.5;
static const double CircleX = 1;
static const double CircleY = 1;

int main(int argc, char** argv) {
    double x,y;
    scanf("%lf %lf",&x,&y);
    
    if(y <= CircleY){
        printf("No");
    }
    else{
        if((x-CircleX) * (x - CircleX) + (y - CircleY) * (y - CircleY) <= RADIUS * RADIUS){
            printf("Yes");
        }
        else{
            printf("No");
        }
    }
    return (EXIT_SUCCESS);
}

