

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    unsigned long long number;
    int sieves;
    scanf("%llu %d",&number,&sieves);
    int i;
    for(i = 0;i<sieves;i++){
        unsigned long long sieve;
        scanf("%llu",&sieve);
        number = number & ~(sieve);
    }
    
    int ones = 0;
    //count ones
    while(number > 0){
        number = number & (number -1);
        ones++;
    }
    printf("%d",ones);
    return (EXIT_SUCCESS);
}

