
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int a,copyA;
    char binaryA[11];
    scanf("%d",&a);
    copyA = a;
    //binary representation
    int i;
    for(i = 9; i >= 0; i--){
        if(copyA > 0){
            binaryA[i] = ((copyA & 1) == 1) ? '1' : '0';
            copyA = copyA >>1;
        }
        else{
            binaryA[i] = '0';
        }
    }
    binaryA[10] = '\0';
        
        
    double b,c;
    scanf("%lf",&b);
    scanf("%lf",&c);
    printf("|%-10X|%-10s|%10.2f|%-10.3f|",a,binaryA,b,c);
    return (EXIT_SUCCESS);
}

