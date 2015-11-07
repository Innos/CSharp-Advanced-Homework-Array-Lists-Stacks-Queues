
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>

int isPalindrome(char* word, size_t len);
void Sort(char** palindromes, size_t len);
int Contains(char** palindromes, size_t len, char* word);
char* toLowerCase(char* word);

char* toLowerCase(char* word) {
    size_t len = strlen(word);
    char* lower = malloc(len + 1);
    int i;
    for (i = 0; i < len; i++) {
        lower[i] = tolower(word[i]);
    }
    lower[len] = '\0';
    return lower;
}

int isPalindrome(char* word, size_t len) {
    int mid = len / 2;
    int end = len - 1;
    int i;
    for (i = 0; i < mid; i++, end--) {
        if (word[i] != word[end]) {
            return 0;
        }
    }
    return 1;
}

//insertion sort
void Sort(char ** palindromes, size_t len) {
    int i;
    for (i = 1; i < len; i++) {
        int j = i;

        while (j > 0) {
            //initialize new char pointers to compare the words as lower cases
            char* lowerTemp1 = toLowerCase(palindromes[j]);
            char* lowerTemp2 = toLowerCase(palindromes[j - 1]);
            if (strcmp(lowerTemp1, lowerTemp2) < 0) {
                //if current element is smaller than previous element swap
                char* temp = palindromes[j];
                palindromes[j] = palindromes[j - 1];
                palindromes[j - 1] = temp;
                j--;
                //free the pointers as they were allocated by malloc
                free(lowerTemp1);
                free(lowerTemp2);
            } else {
                free(lowerTemp1);
                free(lowerTemp2);
                break;
            }
        }
    }
}

int Contains(char** palindromes, size_t len, char* word) {
    int i;
    for (i = 0; i < len; i++) {
        if (strcmp(palindromes[i], word) == 0) {
            return 1;
        }
    }
    return 0;
}

int main(int argc, char** argv) {
    //parse text
    char* text = NULL;
    size_t size = 0;
    ssize_t len = getline(&text, &size, stdin);
    if (text[len - 1] == '\n') {
        text[len - 1] = '\0';
        len = len - 1;
    }

    //create palindromes jagged array
    char** palindromes = malloc(len * sizeof (char*));
    int palindromesSize = 0;
    
    // split text into words
    char*match = strtok(text, " ,.?!");
    while (match) {
        size_t len = strlen(match);
        
        //if the word is a palindrome and is not already in the palindrome array add it
        if (isPalindrome(match, len)) {
            if (!Contains(palindromes, palindromesSize, match)) {
                palindromes[palindromesSize] = malloc(len + 1);
                strcpy(palindromes[palindromesSize], match);
                palindromesSize++;
            }
        }
        match = strtok(NULL, " ,.?!");
    }
    
    Sort(palindromes, palindromesSize);
    
    // print while freeing the palindrome array
    int i;
    for (i = 0; i < len; i++) {
        if (i < palindromesSize) {
            if(i == palindromesSize-1){
                printf("%s", palindromes[i]);
            }
            else{
                printf("%s, ", palindromes[i]);
            }       
        }
        free(palindromes[i]);
    }
    free(palindromes);
    return (EXIT_SUCCESS);
}

