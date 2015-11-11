

#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>

#define BUFFER_SIZE 4096

void print(char* array, int size);

void die(const char * msg);

char * readLineFromFile(FILE * stream);

int main(int argc, char** argv) {

    FILE * file = fopen("02OddLines.c", "r");
    if (!file) {
        die(NULL);
    }
    // start the count from 1 instead of 0, keep in mind
    int lineNumber = 1;
    char buffer[BUFFER_SIZE];
    while (!feof(file)) {
        char * line = readLineFromFile(file);
        size_t len = strlen(line);

        if (lineNumber % 2 == 1) {
            printf("%s\n", line);
        }
        lineNumber++;
    }
    fclose(file);
    return (EXIT_SUCCESS);
}

char * readLineFromFile(FILE * stream) {
    char * buffer = malloc(60 * sizeof (char));
    size_t size = 60;

    int counter = 0;
    char c = fgetc(stream);

    while (c != '\n' && c != EOF) {

        buffer[counter] = c;
        counter++;

        if (counter == size) {
            buffer = realloc(buffer, size * 2);
            if (buffer == NULL) {
                printf("Cannot find sufficent free memory!");
                exit(1);
            }
            size = size * 2;
        }
        c = fgetc(stream);
    }
    char * result = realloc(buffer, counter + 1);
    result[counter] = '\0';

    return result;
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

