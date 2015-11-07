
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char * readLine();
void Quicksort(char** list, int start, int end);

void Quicksort(char** list, int start, int end) {
    if (start < end) {

        // partition
        int mid = (start + end) / 2;
        char * pivot = list[mid];
        int low = start - 1;
        int high = end + 1;

        while (1) {
            do {
                low += 1;
            } while (strcmp(list[low], pivot) < 0);
            do {
                high -= 1;
            } while (strcmp(list[high], pivot) > 0);

            if (low < high) {
                char * temp = list[low];
                list[low] = list[high];
                list[high] = temp;
            } else {
                break;
            }
        }

        Quicksort(list, start, high);
        Quicksort(list, high + 1, end);
    }
}

char * readLine() {
    char * buffer = malloc(60 * sizeof (char));
    size_t size = 60;

    int counter = 0;
    char c = fgetc(stdin);

    while (c != '\n' && c != EOF) {

        buffer[counter] = c;
        counter++;

        if (counter == size) {
            buffer = realloc(buffer, size * 2);
            if (buffer == NULL) {
                printf("Cannot find sufficent free memory!");
                exit(1);
            }
            size = size * 2;
        }
        c = fgetc(stdin);
    }
    char * result = realloc(buffer, counter + 1);
    result[counter] = '\0';

    return result;
}

int main(int argc, char** argv) {
    int citiesCount;
    scanf("%d%*c", &citiesCount);
    char ** cities = malloc(citiesCount * sizeof (char*));
    int i;
    for (i = 0; i < citiesCount; i++) {
        char * city = readLine();
        size_t len = strlen(city);
        cities[i] = malloc(len + 1);
        strcpy(cities[i],city);
        free(city);
    }
    printf("\nSorted:\n");
    Quicksort(cities,0,citiesCount-1);
    for(i=0;i<citiesCount;i++){
        printf("%s\n",cities[i]);
        free(cities[i]);
    }    
    free(cities);
    return (EXIT_SUCCESS);
}

