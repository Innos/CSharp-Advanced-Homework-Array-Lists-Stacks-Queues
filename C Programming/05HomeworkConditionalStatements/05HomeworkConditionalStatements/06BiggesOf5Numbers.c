
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    double a,b,c,d,e;
    scanf("%lf %lf %lf %lf %lf",&a,&b,&c,&d,&e);
    if(a > b){
        b = a;
    }
    if(b > c){
        c = b;
    }
    if(c > d){
        d = c;
    }
    if(d > e){
        e = d;
    }
    printf("%f",e);
    return (EXIT_SUCCESS);
}

