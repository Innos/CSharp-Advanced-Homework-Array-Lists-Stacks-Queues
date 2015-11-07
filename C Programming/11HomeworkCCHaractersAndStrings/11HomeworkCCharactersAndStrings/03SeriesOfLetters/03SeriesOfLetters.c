

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    char* text = NULL;
    size_t size = 0;
    ssize_t len = getline(&text, &size, stdin);
    if (len > 0) {
        if (text[len - 1] == '\n') {
            text[len - 1] = '\0';
            len = len - 1;
        }

        char lastLetter = text[0];
        int lastIndex = 1;

        int i;
        for (i = 1; i < len; i++) {
            if (text[i] == lastLetter) {
                continue;
            }
            text[lastIndex] = text[i];
            lastLetter = text[i];
            lastIndex++;
        }
        text[lastIndex] = '\0';

        printf("%s", text);
    }
    return (EXIT_SUCCESS);
}

