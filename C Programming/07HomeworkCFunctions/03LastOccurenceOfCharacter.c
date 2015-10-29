

#include <stdio.h>
#include <stdlib.h>

int LastIndexOf(char a, char* text);

int LastIndexOf(char a, char* text)
{
    int len = strlen(text);
    int i,index = -1;
    for(i = len -1; i>=0;i--){
        if(text[i] == a){
            index = i;
            break;
        }
    }
    return index;
}

int main(int argc, char** argv) {

    char* text = NULL;
    size_t size = 0;
    getline(&text,&size,stdin);
    char letter;
    scanf("%c*%c",&letter);
    
    printf("%d\n",LastIndexOf(letter,text));
    free(text);
    return (EXIT_SUCCESS);
}

