

#include <stdio.h>
#include <stdlib.h>
#include <errno.h>
#include <string.h>
#include <regex.h>

#define _GNU_SOURCE

typedef struct WordOccurence {
    char * word;
    int occurences;
} WordOccurence;

void die(const char * msg);
char * readLineFromFile(FILE * stream);
void InsertionSort(WordOccurence  * array, size_t count, int (*func)(WordOccurence,WordOccurence));
int occurenceDescendingSorter(WordOccurence a, WordOccurence b);

int main(int argc, char** argv) {
    FILE * wordsStream = fopen("words.txt", "r");
    if (!wordsStream) {
        die(NULL);
    }

    size_t size = 10;
    WordOccurence * words = malloc(size * sizeof (WordOccurence));
    size_t current = 0;

    while (!feof(wordsStream)) {
        if (current == size) {
            words = realloc(words, (size * 2) * sizeof (WordOccurence));
            size = size * 2;
        }

        words[current].word = readLineFromFile(wordsStream);
        words[current].occurences = 0;
        current++;
    }
    fclose(wordsStream);

    FILE * textStream = fopen("text.txt", "r");
    if (!textStream) {
        die(NULL);
    }
    
    regex_t regex;
    while (!feof(textStream)) {
        char * line = readLineFromFile(textStream);
        int j;
        for (j = 0; j < current; j++) {
            char pattern[30];
            memset(pattern,0,sizeof(pattern));
            char * word = words[j].word;
            sprintf(pattern,"[^A-Za-z]%s[^A-Za-z]",words[j].word);
            regcomp(&regex,pattern,REG_ICASE);
            char * temp = line;
            regmatch_t groupArray[1];
            int reti = regexec(&regex,temp,1,groupArray,0);
            while(!reti)
            {
                temp += groupArray[0].rm_eo;
                words[j].occurences++;
                reti = regexec(&regex,temp,1,groupArray,0);
            }
            regfree(&regex);
        }
        free(line);
    }
    fclose(textStream);
    
    InsertionSort(words,current,&occurenceDescendingSorter);

    FILE * result = fopen("result.txt", "w");
    if (!result) {
        die(NULL);
    }
    int i;
    for(i=0;i<current;i++)
    {
        fprintf(result,"%s - %d\n",words[i].word,words[i].occurences);
        free(words[i].word);
    }
    free(words);
    fclose(result);
    
    return (EXIT_SUCCESS);
}

char * readLineFromFile(FILE * stream) {
    char * buffer = malloc(60 * sizeof (char));
    size_t size = 60;

    int counter = 0;
    char c = fgetc(stream);

    while (c != '\n' && c != EOF) {

        buffer[counter] = c;
        counter++;

        if (counter == size) {

            buffer = realloc(buffer, size * 2);
            if (buffer == NULL) {
                printf("Cannot find sufficient free memory!");
                exit(1);
            }
            size = size * 2;
        }
        c = fgetc(stream);
    }
    char * result = realloc(buffer, counter + 1);
    result[counter] = '\0';

    return result;
}

void die(const char * msg) {
    if (errno) {
        perror(msg);
    } else {
        printf("ERROR %s\n", msg);
    }
    exit(1);
}

void InsertionSort(WordOccurence  * array, size_t count, int (*func)(WordOccurence,WordOccurence)) {
    int i;
    for (i = 1; i < count; i++) {
        int j = i;
        while (j > 0 && (*func)(array[j - 1], array[j]) > 0) {
            WordOccurence temp = array[j - 1];
            array[j - 1] = array[j];
            array[j] = temp;
            j--;
        }
    }
}

int occurenceDescendingSorter(WordOccurence a, WordOccurence b)
{
    if(b.occurences > a.occurences)
    {
        return 1;
    }
    else if(a.occurences > b.occurences)
    {
        return -1;
    }
    else
    {
        return 0;
    }
}

