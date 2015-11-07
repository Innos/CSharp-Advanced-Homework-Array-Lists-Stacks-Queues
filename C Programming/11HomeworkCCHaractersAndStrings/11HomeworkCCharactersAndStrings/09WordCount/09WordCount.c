

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int WordCount(char* text, char delimiter);

int WordCount(char* text, char delimiter){
    int count = 1;
    char ch = *text;
    while(ch != '\0'){
        if(ch == delimiter){
              count++;
        }     
        ch = *(++text);
    }
    return count;
}

int main(int argc, char** argv) {

    int count1 = WordCount("Hard Rock, Hallelujah!", ' ');
    int count2 = WordCount("Hard Rock, Hallelujah!", ',');
    int count3 = WordCount("Uncle Sam wants you Man", ' ');
    int count4 = WordCount("Beat the beat!", '!');
    
    printf("%d\n",count1);
    printf("%d\n",count2);
    printf("%d\n",count3);
    printf("%d\n",count4);
    
    return (EXIT_SUCCESS);
}

