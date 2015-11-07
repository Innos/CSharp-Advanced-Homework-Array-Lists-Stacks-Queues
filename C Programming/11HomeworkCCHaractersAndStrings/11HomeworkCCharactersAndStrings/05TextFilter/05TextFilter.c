

#include <stdio.h>
#include <stdlib.h>
#include <string.h>


int main(int argc, char** argv) {
    char*patternString = NULL;
    size_t size = 0;
    ssize_t len = getline(&patternString, &size, stdin);
    if (patternString[len - 1] == '\n') {
        patternString[len - 1] = '\0';
        len = len - 1;
    }
    
    char* text = NULL;
    size_t textSize = 0;
    ssize_t textLen = getline(&text,&textSize,stdin);

    char*pattern = strtok(patternString, ", ");
    while (pattern) {
        size_t patternLength = strlen(pattern);
        char* match = strstr(text,pattern);
        while(match){
            memset(match,'*',patternLength);
            match = strstr(match+1,pattern);
        }
        pattern = strtok(NULL,", ");
    }
    
    printf("%s",text);

    return (EXIT_SUCCESS);
}

