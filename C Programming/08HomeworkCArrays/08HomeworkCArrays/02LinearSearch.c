
#include <stdio.h>
#include <stdlib.h>

char* LinearSearch(int * numbers,size_t len,int element);

char* LinearSearch(int * numbers,size_t len,int element){
    int i;
    for(i = 0;i<len;i++){
        if(numbers[i] == element){
            return "yes";
        }
    }
    return "no";
}

int main(int argc, char** argv) {

    int size;
    scanf("%d",&size);
    int numbers[size];
    int i;
    for(i = 0;i<size;i++){
        scanf("%d",&numbers[i]);
    }
    int element;
    scanf("%d",&element);
    char* result = LinearSearch(numbers,size,element);
    printf("%s",result);
    
    return (EXIT_SUCCESS);
}

