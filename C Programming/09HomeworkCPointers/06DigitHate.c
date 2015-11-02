

#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

int killDigits(char* original, char ** result);

int killDigits(char* original, char ** result)
{
    int changed = 0;
    size_t len = strlen(original);
    *result = malloc((len+1) * sizeof(char));
    int i;
    for(i=0;i<len;i++){
        if(isdigit(original[i])){
            (*result)[i] = '/';
            changed += 1;
        }
        else{
            (*result)[i] = original[i];
        }
    }
    result[len] = '\0';
    
    return changed;
}

int main(int argc, char** argv) {
    printf("Input the text all in a single line (\\n is the delimiter):\n");
    char * text = NULL;
    size_t size = 0;
    getline(&text,&size,stdin);
    char * result;
    int changed = killDigits(text,&result);
    printf("\n%s\nChanged: %d",result,changed);
    return (EXIT_SUCCESS);
}

