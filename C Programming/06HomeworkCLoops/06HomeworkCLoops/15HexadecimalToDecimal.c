
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    char* line = NULL;
    size_t size = 0;
    getline(&line,&size,stdin);
    int len = strlen(line);
    if(line[len-1] == '\n'){
        line[len-1] = '\0';
    }
    long number = strtol(line,NULL,16);
    printf("%li",number);
    return (EXIT_SUCCESS);
}

