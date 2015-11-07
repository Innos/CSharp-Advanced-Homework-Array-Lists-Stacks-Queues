
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char * readLine();
int Contains(char** list, size_t len, char* word);

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

int Contains(char** list, size_t len, char* word) {
    int i;
    for (i = 0; i < len; i++) {
        if (strcmp(list[i], word) == 0) {
            return 1;
        }
    }
    return 0;
}

int main(int argc, char** argv) {
    char * line1 = readLine();
    size_t line1Len = strlen(line1);
    char * line2 = readLine();
    size_t line2Len = strlen(line2);
    char ** list1 = malloc(line1Len * sizeof (char*));
    char ** list2 = malloc(line2Len * sizeof (char*));
    size_t list1Size = 0;
    size_t list2Size = 0;

    char* match2 = strtok(line2, " ");
    while (match2) {
        size_t matchLen = strlen(match2);
        list2[list2Size] = malloc(matchLen + 1);
        strcpy(list2[list2Size], match2);
        list2Size++;
        match2 = strtok(NULL, " ");
    }

    char * match = strtok(line1, " ");
    while (match) {
        if (!Contains(list2, list2Size, match)) {
            size_t matchLen = strlen(match);
            list1[list1Size] = malloc(matchLen + 1);
            strcpy(list1[list1Size], match);
            list1Size++;
        }
        match = strtok(NULL, " ");
    }
    free(line1);
    free(line2);
    int i;
    for(i=0;i<list2Size;i++){
        free(list2[i]);
    }
    free(list2);
    
    for(i=0;i<list1Size;i++){
        printf("%s ",list1[i]);
        free(list1[i]);
    }
    free(list1);
    return (EXIT_SUCCESS);
}

