
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {

    char* text = NULL;
    size_t size = 0;
    ssize_t len = getline(&text, &size, stdin);
    if (len > 0) {
        if (text[len - 1] == '\n') {
            text[len - 1] == '\0';
            len = len - 1;
        }

        char* reversed = malloc(len + 1);
        int i, start = 0;
        for (i = len - 1; i >= 0; i--) {
            reversed[start] = text[i];
            start++;
        }
        reversed[start] = '\0';
        printf("%s", reversed);
    } else {
        printf("Error no input.");
    }
    return (EXIT_SUCCESS);
}

