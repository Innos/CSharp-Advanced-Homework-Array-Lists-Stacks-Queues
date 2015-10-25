

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    char* line = NULL;
    size_t size = 0;
    getline(&line, &size, stdin);
    int len = strlen(line);
    if (line[len - 1] == '\n') {
        line[len - 1] = '\0';
    }
    int i;
    long temp = 1;
    long number = 0;
    for (i = len-2; i >= 0; i--) {
        if (line[i] == '1') {
            number += temp;
        }
        temp *= 2;
    }
    printf("%li", number);
    free(line);
    return (EXIT_SUCCESS);
}

