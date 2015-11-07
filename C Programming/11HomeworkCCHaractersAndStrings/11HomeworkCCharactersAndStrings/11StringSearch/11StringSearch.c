
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int StringSearch(char* text, char* string);

int StringSearch(char* text, char* string) {
    size_t len = strlen(text);
    size_t patternLen = strlen(string);

    if (patternLen > len) {
        return 0;
    }
    int i, letter = 0, count = 0;
    for (i = 0; i < len; i++) {
        if (text[i] == string[letter]) {
            letter++;
            if (string[letter] == '\0') {
                return 1;
            }
        }
    }


    return 0;
}

int main(int argc, char** argv) {
    printf("%d\n", StringSearch("SoftUni", "Soft"));
    printf("%d\n", StringSearch("Hard Rock", "Rock"));
    printf("%d\n", StringSearch("Ananas", "nasa"));
    printf("%d\n", StringSearch("Coolness", "cool"));
    return (EXIT_SUCCESS);
}

