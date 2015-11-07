
#include <stdio.h>
#include <stdlib.h>


int main(int argc, char** argv) {
    char text[21];
    memset(text,0,sizeof(text));
    fgets(text,21,stdin);
    int i;
    for(i=0;i<20;i++)
    {
        if(text[i] == '\0' || text[i] == '\n'){
            text[i] = '*';
        }
    }
    
    printf("%s",text);
    return (EXIT_SUCCESS);
}

