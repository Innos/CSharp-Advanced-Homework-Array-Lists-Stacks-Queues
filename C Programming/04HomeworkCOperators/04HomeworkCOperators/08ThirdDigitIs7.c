
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    long a;
    scanf("%li",&a);
    printf("%s",((a / 100) % 10) == 7? "True" : "False");
    return (EXIT_SUCCESS);
}

