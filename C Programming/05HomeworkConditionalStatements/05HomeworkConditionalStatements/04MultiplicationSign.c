
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    double a,b,c;
    scanf("%lf %lf %lf",&a,&b,&c);
    if(a == 0 || b == 0 || c == 0){
        printf("0");
    }
    else{
        if(a > 0){
            if(b>0){
                if(c > 0){
                    printf("+");
                }
                else{
                    printf("-");
                }
            }
            else{
                if(c > 0){
                    printf("-");
                }
                else{
                    printf("+");
                }
            }
        }
        else{
            if(b > 0){
                if(c > 0){
                    printf("-");
                }
                else{
                    printf("+");
                }
            }
            else{
                if(c > 0){
                    printf("+");
                }
                else{
                    printf("-");
                }
            }
        }
    }
    return (EXIT_SUCCESS);
}

