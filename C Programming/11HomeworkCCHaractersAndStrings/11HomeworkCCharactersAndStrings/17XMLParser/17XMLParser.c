

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

char * readLine();

char * readLine() {
    char * buffer = malloc(60 * sizeof (char));
    size_t size = 60;

    int counter = 0;
    char c = fgetc(stdin);

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
        c = fgetc(stdin);
    }
    char * result = realloc(buffer, counter + 1);
    result[counter] = '\0';

    return result;
}

//Enter One Line at a time
int main(int argc, char** argv) {
    char * line = readLine();
    while (*line != '\0') {
        char * match = strtok(line, "<>");
        int counter = 0;
        char * openingTag;
        char * value;
        
        while (match) {
            if (counter == 0) {
                openingTag = match;
                counter++;
            } else if (counter == 1) {
                value = match;
                counter++;
            } else if (counter == 2 && *(match) == '/' && strcmp((match + 1), openingTag) == 0) {
                counter++;
            }
            match = strtok(NULL,"<>");
        }
        if(counter<3){
         printf("Invalid Format\n");   
        }
        else{
            openingTag[0] = toupper(openingTag[0]);
            printf("%s: %s\n",openingTag,value);
        }
        free(line);
        line = readLine();
    }
    return (EXIT_SUCCESS);
}

