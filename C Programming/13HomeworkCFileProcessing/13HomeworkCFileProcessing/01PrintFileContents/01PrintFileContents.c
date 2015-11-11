

#include <stdio.h>
#include <stdlib.h>
#include <errno.h>

#define BUFFER_SIZE 4096

void print();
void die(const char * msg);

int main(int argc, char** argv) {
    //this program opens the file "Test.txt" which is right next to this .c file
    // if it doesn't work you probably didn't copy it along with the .c files
    FILE * file = fopen("Test.txt", "r");
    if (!file) {
        die(NULL);
    }
    char buffer[BUFFER_SIZE];
    while (!feof(file)) {
        int bytesRead = fread(buffer, 1, BUFFER_SIZE, file);

        print(buffer, bytesRead);
    }
    fclose(file);
    return (EXIT_SUCCESS);
}

void print(char * array, int size) {
    int i;
    for (i = 0; i < size; i++) {
        printf("%c", array[i]);
    }
}

void die(const char * msg) {
    if (errno) {
        perror(msg);
    } else {
        printf("ERROR %s\n", msg);
    }
    exit(1);
}

