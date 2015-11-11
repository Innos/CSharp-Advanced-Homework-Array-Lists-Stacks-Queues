
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <errno.h>

void die(const char * msg);

char * readLineFromFile(FILE * stream);

int main(int argc, char** argv) {
    FILE * source = fopen("03LineNumbers.c", "r");
    if (!source) {
        die(NULL);
        return 1;
    }
    FILE * dest = fopen("TestOutput.c", "w");
    if (!dest) {
        die(NULL);
        return 1;
    }
    int lineNumber = 0;
    while (!feof(source)) {
        char * line = readLineFromFile(source);
        size_t len = strlen(line);
        fprintf(dest, "%d %s\n", lineNumber, line);
        lineNumber++;
        free(line);
    }
    fclose(dest);
    fclose(source);

    return (EXIT_SUCCESS);
}

char * readLineFromFile(FILE * stream) {
    char * buffer = malloc(120 * sizeof (char));
    size_t size = 120;

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

void die(const char * msg) {
    if (errno) {
        perror(msg);
    } else {
        printf("ERROR %s\n", msg);
    }
    exit(1);
}

