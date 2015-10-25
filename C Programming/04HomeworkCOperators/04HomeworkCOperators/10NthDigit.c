
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    long number;
    int digit;
    scanf("%li %d",&number,&digit);
    int i;
    for(i=1; i< digit;i++){
        number = number /10;
    }
    if(number == 0){
        printf("-");
    }
    else{
        int nthDigit = number % 10;
        printf("%d",nthDigit);
    }
    
    return (EXIT_SUCCESS);
}

