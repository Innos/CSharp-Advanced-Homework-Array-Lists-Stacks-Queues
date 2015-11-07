
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* stringCopy(char* buffer, char* original, size_t len);

char* stringCopy(char* buffer, char* original, size_t size) {
    int i;
    for (i = 0; i < size && original[i] != '\0'; i++) {
        buffer[i] = original[i];
    }
    for (; i < size; i++) {
        buffer[i] = '\0';
    }

    return buffer;
}

int main(int argc, char** argv) {
    char copy[10];
    char copy2[10];
    char copy3[10];
    memset(copy3,0,sizeof(copy3));
    memset(copy2,0,sizeof(copy2));
    
    char * result = stringCopy(copy, "SoftUni", 7);
    printf("%s\n", copy);
    //keep in mind that this like the default implementation of strncpy will not automatically add a null terminator if the size copied
    // is less than the original word, printing a non null terminated pointer may result in incorrect behavior
    // the null terminator of the original word will be copied if it's within the given size though
    stringCopy(copy2, "SoftUni", 3);
    printf("%s\n", copy2);
    
    // no bytes are overwritten so no null terminator is added, it is essentially printing garbage memory
    // in the standard implementation it's up to the user to make sure the destination contains no garbage data
    stringCopy(copy3, "C is cool", 0);
    printf("%s\n",copy3);
    
    //returning a char* from the function without using a buffer will return a pointer to garbage memory
    // one way to correct it is to malloc the memory before we return a pointer to it,
    // however then we would have to free it
    return (EXIT_SUCCESS);
}

