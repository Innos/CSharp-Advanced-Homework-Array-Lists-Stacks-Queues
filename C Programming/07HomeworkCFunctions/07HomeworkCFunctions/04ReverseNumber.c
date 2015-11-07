

#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#include <math.h>

double ReverseNumber(char* number, int* error);

double ReverseNumber(char* number, int* error) {
    int len = strlen(number);
    double num = 0;
    int i, dotIndex = 0;
    for (i = len - 1; i >= 0; i--) {
        if (isdigit(number[i])) {
            num = num * 10 + (number[i] - '0');
        } else if (number[i] == '.') {
            dotIndex = i;
        } else {
            *error = 1;
            return;
        }
    }
    num = num * pow(0.1, dotIndex);
    *error = 0;
    return num;
}

int main(int argc, char** argv) {

    int error;

    char* num = NULL;
    size_t size = 0;
    getline(&num, &size, stdin);
    int len = strlen(num);
    if (num[len - 1] == '\n') {
        num[len - 1] = '\0';
    }


    double number = ReverseNumber(num, &error);

    if (error) {
        printf("Invalid format");
    } else {
        printf("%.3f", number);
    }
    return (EXIT_SUCCESS);
}

