
#include <stdio.h>
#include <stdlib.h>

void Print(int number);

int main(int argc, char** argv) {
    int number;
    scanf("%d", &number);

    switch (number) {
        case 1:
        case 2:
        case 3:
            number *= 10;
            Print(number);
            break;
        case 4:
        case 5:
        case 6:
            number *= 100;
            Print(number);
            break;
        case 7:
        case 8:
        case 9:
            number *= 1000;
            Print(number);
            break;
        default:
            printf("Invalid score");
            break;

    }
    return (EXIT_SUCCESS);
}

void Print(int number){
    printf("%d",number);
}

