

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* StringConcatenation(char* destination, char* source, size_t size);

char* StringConcatenation(char* destination, char* source, size_t size) {
    size_t destLen = strlen(destination);

    int i;
    for (i = 0; i < size && source[i] != '\0'; i++) {
        destination[destLen + i] = source[i];
    }
    destination[destLen + i] = '\0';

    return destination;
}

int main(int argc, char** argv) {
    char buffer[10] = "Soft";
    StringConcatenation(buffer, "Uni", 7);
    printf("%s\n",buffer);

    // Stack smashing, there is not enough room in the buffer for the concatenated string
    //char buffer2[5] = "Soft";
    //StringConcatenation(buffer2, "ware University", 15);
    
    char buffer3[10] = "C";
    StringConcatenation(buffer3," is cool",8);
    printf("%s\n",buffer3);
    
    // buffer 4 is initialized as a string literal and thus lives in the read only memory, trying
    // to change it will cause segmentation fault
    //char* buffer4 = "C";
    //StringConcatenation(buffer4," is cool",8);
    return (EXIT_SUCCESS);
}

