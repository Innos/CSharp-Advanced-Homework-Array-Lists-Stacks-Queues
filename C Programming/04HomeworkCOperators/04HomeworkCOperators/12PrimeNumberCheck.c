

#include <stdio.h>
#include <stdlib.h>
#include <math.h>

//include math library
char* CheckPrimeNumber(int number);

int main(int argc, char** argv) {
    int number;
    scanf("%d", &number);
    if (number < 2) {
        printf("False");
    } else {
        char* result = CheckPrimeNumber(number);
        printf("%s",result);
    }
    return (EXIT_SUCCESS);
}

char* CheckPrimeNumber(int number){
    int roof = sqrt(number);
        int i;
        for (i = 2; i <= roof; i++) {
            if (number % i == 0) {
                return "False";
            }
        }
        return "True";
}

