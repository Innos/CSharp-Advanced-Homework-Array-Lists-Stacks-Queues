#define _GNU_SOURCE
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char** argv) {
    char* text = NULL;
    size_t size = 0;
    char* pattern = NULL;
    size_t patternSize = 0;

    ssize_t len = getline(&text, &size, stdin);
    if (len > 0) {
        if (text[len - 1] == '\n') {
            text[len - 1] = '\0';
            len = len - 1;
        }

        ssize_t patternLen = getline(&pattern, &patternSize, stdin);
        if (patternLen > 0) {
            if (pattern[patternLen - 1] == '\n') {
                pattern[patternLen - 1] = '\0';
                patternLen = patternLen - 1;
            }
            int counter = 0;
            char* match = strcasestr(text,pattern);
            while(match){
                counter++;
                match = strcasestr(match+1,pattern);
            }
            printf("%d",counter);
        }
    }


    return (EXIT_SUCCESS);
}

