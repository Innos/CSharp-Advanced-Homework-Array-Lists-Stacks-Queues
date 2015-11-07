

#include <stdio.h>
#include <stdlib.h>

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
    int size;
    scanf("%d%*c",&size);
    char *** matrix = malloc(size*sizeof(char*));
    int row;
    for(row = 0;row<size;row++){
        char * line = readLine();
        matrix[row] = malloc(size * sizeof(char*));
        int col = 0;
        char * city = strtok(line," ");
        while(city){
            size_t len = strlen(city);
            matrix[row][col] = malloc(len + 1);
            strcpy(matrix[row][col],city);
            col++;
            city = strtok(NULL," ");
        }
        free(line);
    }
    int col;
    for(row = 0;row<size;row++){
        for(col=0;col<size;col++){
            if(col == row){
                printf("%s\n",matrix[row][col]);
            }
            free(matrix[row][col]);
        }
        free(matrix[row]);
    }
    free(matrix);
    return (EXIT_SUCCESS);
}

