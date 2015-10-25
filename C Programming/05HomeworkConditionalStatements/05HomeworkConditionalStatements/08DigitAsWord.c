
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    char input[3];
    fgets(input, sizeof input, stdin);
    if (input[1] != '\n') {
        printf("not a digit");
    } else {
        switch (input[0]) {
            case '0': printf("zero");
                break;
            case '1': printf("one");
                break;
            case '2': printf("two");
                break;
            case '3': printf("three");
                break;
            case '4': printf("four");
                break;
            case '5': printf("five");
                break;
            case '6': printf("six");
                break;
            case '7': printf("seven");
                break;
            case '8': printf("eight");
                break;
            case '9': printf("nine");
                break;
            default: printf("not a digit");
                break;
        }
    }
    return (EXIT_SUCCESS);
}

