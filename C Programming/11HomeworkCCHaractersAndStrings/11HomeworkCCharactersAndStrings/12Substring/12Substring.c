
#include <stdio.h>
#include <stdlib.h>

char* Substring(char* text, int position, int length);

char* Substring(char* text, int position, int length) {
    size_t len = strlen(text);

    if (position >= len) {
        char * result = malloc(1);
        result[0] = '\0';
        return result;
    }

    char * result = calloc(length + 1, sizeof(char));
    int i;
    for(i=0;i<length;i++){
        if(position + i < len){
            result[i] = text[position+i];
        }
    }
    return result;
}

int main(int argc, char** argv) {
    char * substring1 =Substring("Breaking Bad", 0, 2);
    char * substring2 =Substring("Maniac", 3, 3);
    char * substring3 =Substring("Maniac", 3, 5);
    char * substring4 =Substring("Master Yoda", 13, 5);
    
    printf("%s\n",substring1);
    printf("%s\n",substring2);
    printf("%s\n",substring3);
    printf("%s\n",substring4);
    
    free(substring1);
    free(substring2);
    free(substring3);
    free(substring4);
    return (EXIT_SUCCESS);
}

