
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* LastDigitOfNumber(int a);

char* LastDigitOfNumber(int a){
 char * word = malloc(10* sizeof(char));
 int lastDigit = a % 10;
 
 switch(lastDigit){
     case 0: strcpy(word,"zero"); break;
     case 1: strcpy(word,"one"); break;
     case 2: strcpy(word,"two"); break;
     case 3: strcpy(word,"three"); break;
     case 4: strcpy(word,"four"); break;
     case 5: strcpy(word,"five"); break;
     case 6: strcpy(word,"six"); break;
     case 7: strcpy(word,"seven"); break;
     case 8: strcpy(word,"eight"); break;
     case 9: strcpy(word,"nine"); break;   
 }
 
 return word;
}

int main(int argc, char** argv) {
    int number;
    scanf("%d",&number);
    char* word = LastDigitOfNumber(number);
    printf("%s",word);
    free(word);
    return (EXIT_SUCCESS);
}

