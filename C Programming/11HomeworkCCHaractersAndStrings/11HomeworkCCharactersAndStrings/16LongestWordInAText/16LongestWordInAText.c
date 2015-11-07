

#include <stdio.h>
#include <stdlib.h>
#include <string.h>


int main(int argc, char** argv) {
    char * text = NULL;
    size_t size = 0;
    ssize_t len = getline(&text,&size,stdin);
    
    char * match = strtok(text," .");
    char * longest;
    size_t longestSize = 0;
    while(match){
        size_t matchLen = strlen(match);
        if(matchLen > longestSize){
            longest = match;
            longestSize = matchLen;
        }
        match = strtok(NULL," .");
    }
    printf("%s",longest);
    free(text);
    return (EXIT_SUCCESS);
}

