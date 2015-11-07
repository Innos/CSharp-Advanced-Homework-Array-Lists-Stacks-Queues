
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

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

int main(int argc, char** argv) {

    int lines;
    scanf("%d%*c", &lines);

    char * max;
    int maxTimes;
    char * current;
    int count;

    int i;
    for (i = 0; i < lines; i++) {
        char * line = readLine();
        size_t len = strlen(line);

        if(i == 0){
            current = malloc(len +1);
            strcpy(current,line);
            count = 1;
            max = malloc(len + 1);
            strcpy(max,line);
            maxTimes = 1;
        }
        else if(strcmp(current,line) == 0){
            count++;
        }
        else{
            free(current);
            current = malloc(len + 1);
            strcpy(current,line);
            count = 1;
        }
        
        if(maxTimes < count){
            free(max);
            max = malloc(len + 1);
            strcpy(max,line);
            maxTimes = count;
        } 
        free(line);
    }
    printf("%d\n",maxTimes);
    for(i = 0;i<maxTimes;i++){
        printf("%s\n",max);
    }
    free(max);
    free(current);
    
    return (EXIT_SUCCESS);
}

