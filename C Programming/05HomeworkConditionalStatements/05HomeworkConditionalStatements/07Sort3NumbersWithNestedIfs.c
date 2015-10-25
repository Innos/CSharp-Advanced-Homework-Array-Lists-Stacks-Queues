
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    double a,b,c;
    scanf("%lf %lf %lf",&a,&b,&c);
    if(a > b && a > c){
        if(c > b){
            //swap c and b
            double temp = c;
            c = b;
            b = temp;
        }
    }
    else if (b > a && b > c){
        // swap a and b
        double temp = a;
        a = b;
        b = temp;
        
        if(c > b){
            //swap c and b
            temp = c;
            c = b;
            b = temp;
        }
    }
    else if(c > a && c > b){
        //swap c and a
        double temp = a;
        a = c;
        c = temp;
        
        if(c > b){
            //swap c and b
            temp = b;
            b = c;
            c = temp;
        }
    }
    printf("%f %f %f",a,b,c);
    return (EXIT_SUCCESS);
}

