

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    long factorial = 1;
    double divisor = 1; 
    double sum = 1;
    int n,x;
    scanf("%d %d",&n,&x);
    int i;
    for(i= 1;i<=n;i++){
     factorial = factorial * i;
     divisor = divisor * x;
     sum += factorial/divisor;
    }
    printf("%f",sum);
    return (EXIT_SUCCESS);
}

