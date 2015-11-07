

#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    int value;
    long num,position;
    scanf("%li %li %d",&num,&position,&value);
    if(value == 0){
        long mask = ~((long)1 << position);
        num = num & mask;
    }
    else{
        long mask = (long)1 << position;
        num = num | mask;
    }
    printf("%li",num);
    
    return (EXIT_SUCCESS);
}

