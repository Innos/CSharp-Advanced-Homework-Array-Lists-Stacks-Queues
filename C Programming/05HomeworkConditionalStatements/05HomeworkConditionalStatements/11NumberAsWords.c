

#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>

void Capitalize(char* word);
char* DecimalExchange(int number);
char* Exchange(int number);

int main(int argc, char** argv) {
    int number;
    scanf("%d", &number);
    if (number < 0 || number > 999) {
        printf("Incorrect input");
    } else if (number == 0) {
        printf("Zero");
    } else if (number < 20) {
        char* word = Exchange(number);
        Capitalize(word);
        printf("%s", word);
        free(word);
    } else if (number < 100) {
        char* word1 = DecimalExchange(number / 10);
        char* word2 = Exchange(number % 10);
        Capitalize(word1);
        printf("%s %s", word1, word2);
        free(word1);
        free(word2);
    } else if (number % 100 == 0) {
        char* word = Exchange(number / 100);
        Capitalize(word);
        printf("%s hundred", word);
        free(word);
    } else if ((number % 100) < 20){
        char* word1 = Exchange(number/100);
        char* word2 = Exchange(number %100);
        Capitalize(word1);
        printf("%s hundred and %s",word1,word2);
        free(word1);
        free(word2);
    }else{
        char* word1 = Exchange(number/100);
        char* word2 = DecimalExchange((number/10) % 10);
        char* word3 = Exchange(number%10);
        Capitalize(word1);
        printf("%s hundred and %s %s",word1,word2,word3);
        free(word1);
        free(word2);
        free(word3);
    }
        return (EXIT_SUCCESS);
}

void Capitalize(char* word) {
    char letter = toupper(word[0]);
    word[0] = letter;
}

char* DecimalExchange(int number) {
    char* word = malloc(10 * sizeof (char));
    memset(word, 0, sizeof word);
    switch (number) {
        case 2: strcpy(word, "twenty");
            break;
        case 3: strcpy(word, "thirty");
            break;
        case 4: strcpy(word, "forty");
            break;
        case 5: strcpy(word, "fifty");
            break;
        case 6: strcpy(word, "sixty");
            break;
        case 7: strcpy(word, "seventy");
            break;
        case 8: strcpy(word, "eighty");
            break;
        case 9: strcpy(word, "ninety");
            break;
    }
    return word;
}

char* Exchange(int number) {
    char* word = malloc(10 * sizeof (char));
    memset(word, 0, sizeof word);
    switch (number) {
        case 1: strcpy(word, "one");
            break;
        case 2: strcpy(word, "two");
            break;
        case 3: strcpy(word, "three");
            break;
        case 4: strcpy(word, "four");
            break;
        case 5: strcpy(word, "five");
            break;
        case 6: strcpy(word, "six");
            break;
        case 7: strcpy(word, "seven");
            break;
        case 8: strcpy(word, "eight");
            break;
        case 9: strcpy(word, "nine");
            break;
        case 10: strcpy(word, "ten");
            break;
        case 11: strcpy(word, "eleven");
            break;
        case 12: strcpy(word, "twelve");
            break;
        case 13: strcpy(word, "thirteen");
            break;
        case 14: strcpy(word, "fourteen");
            break;
        case 15: strcpy(word, "fifteen");
            break;
        case 16: strcpy(word, "sixteen");
            break;
        case 17: strcpy(word, "seventeen");
            break;
        case 18: strcpy(word, "eighteen");
            break;
        case 19: strcpy(word, "nineteen");
            break;
    }
    return word;
}

