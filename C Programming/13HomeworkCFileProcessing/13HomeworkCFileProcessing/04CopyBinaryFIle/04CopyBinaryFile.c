

#include <stdio.h>
#include <stdlib.h>
#include <errno.h>

#define BUFFER_SIZE 4096

void die(const char * msg);

//IMPORTANT this program uses the image "programmers.jpg" to demonstrate it's own function

int main(int argc, char** argv) {

    FILE * source = fopen("programmers.jpg", "r");
    if (!source) {
        die(NULL);
        return 1;
    }
    FILE * dest = fopen("Destination.jpg", "w");
    if (!dest) {
        die(NULL);
        return 1;
    }

    char buffer[BUFFER_SIZE];
    while (!feof(source)) {
        int bytesRead = fread(buffer, 1, BUFFER_SIZE, source);
        fwrite(buffer, 1, bytesRead, dest);
    }

    fclose(source);
    fclose(dest);
    return (EXIT_SUCCESS);
}

void die(const char * msg) {
    if (errno) {
        perror(msg);
    } else {
        printf("ERROR %s\n", msg);
    }
    exit(1);
}

