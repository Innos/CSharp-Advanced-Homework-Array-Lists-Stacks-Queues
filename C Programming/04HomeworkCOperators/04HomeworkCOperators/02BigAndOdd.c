
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    
    int a;
    scanf("%d",&a);
    printf("%s",(a > 20 && a %2 == 1)? "True" : "False");
    return (EXIT_SUCCESS);
}

