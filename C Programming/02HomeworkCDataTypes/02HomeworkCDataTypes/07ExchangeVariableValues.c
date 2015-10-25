
#include <stdio.h>
#include <stdlib.h>


int main() {
    int a = 5;
    int b = 10;
    printf("Before:\na = %d\nb = %d\n",a,b);
    
    //swap
    int temp = a;
    a = b;
    b = temp;
    
    printf("After:\na = %d\nb = %d\n",a,b);
    
    return (EXIT_SUCCESS);
}

