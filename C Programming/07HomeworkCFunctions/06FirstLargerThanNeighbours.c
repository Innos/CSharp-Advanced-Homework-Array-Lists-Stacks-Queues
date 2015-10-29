

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int FirstLargerThanNeighbours(long* numbers,size_t len);

int FirstLargerThanNeighbours(long* numbers,size_t len){
    int i;
    for(i = 0;i<len;i++){
        if(i>0 && i < len-1)
        {
            if(numbers[i] > numbers[i-1] && numbers[i]> numbers[i+1]){
                return i;
            }
        }   
    }
    return -1;
}


int main(int argc, char** argv) {

    printf("Input all elements of the array on the same line seperated by a space:\n");
    
    char* line = NULL;
    size_t size = 0;
    getline(&line, &size, stdin);
    int len = strlen(line);
    if (line[len - 1] == '\n') {
        line[len - 1] = '\0';
    }

    long numbers[50];
    size_t length = 0;
    char* elements = strtok(line, ", ");
    while (elements != NULL) {
        numbers[length] = strtol(elements,NULL,10);
        length++;
        elements = strtok(NULL, ", ");
    }
    
    int index = FirstLargerThanNeighbours(numbers,length);
    printf("Index: %d",index);

    return (EXIT_SUCCESS);
}

