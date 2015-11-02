

#include <stdio.h>
#include <stdlib.h>
char * readLine();

char * readLine(){
    char * buffer = malloc(60 * sizeof(char));
    size_t size = 60;
    
    int counter = 0;
    char c = getc(stdin);
    
    while(c != '\n'){
        
        buffer[counter] = c;
        counter++;
        
        if(counter == size){
            buffer = realloc(buffer, size * 2);
            size = size* 2;
        }
        c = getc(stdin);
    }
    return buffer;
}

int main(int argc, char** argv) {
    char * text = readLine();
    printf("%s",text);
    return (EXIT_SUCCESS);
}

