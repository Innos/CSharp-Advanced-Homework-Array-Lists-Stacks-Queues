
#include <stdio.h>
#include <stdlib.h>

static int i = 0;

void StringReverse(char* original, char* reversed);

void StringReverse(char* original, char* reversed){
    if(*original){
        StringReverse(original+1,reversed);
        reversed[i++] = *original;
    }
}

// make sure the return char array is initialized with \0 null terminators;
int main(int argc, char** argv) {
    char name[] = "Recursion";
    char rev[sizeof(name)] = {0};
    StringReverse(name,rev);
    printf("%s",rev);
    return (EXIT_SUCCESS);
}

