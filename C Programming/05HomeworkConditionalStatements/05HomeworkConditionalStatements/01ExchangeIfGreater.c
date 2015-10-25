

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    double a,b;
    scanf("%lf %lf",&a,&b);
    printf("Before:\na = %f\nb = %f\n",a,b);
    if(a > b){
        //swap
        double temp = a;
        a = b;
        b = temp;
    }
    printf("After:\na = %f\nb = %f\n",a,b);
    
    return (EXIT_SUCCESS);
}

