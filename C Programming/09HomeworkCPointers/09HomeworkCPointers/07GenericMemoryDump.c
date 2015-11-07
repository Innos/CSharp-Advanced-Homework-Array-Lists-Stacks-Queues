

#include <stdio.h>
#include <stdlib.h>

void mem_dump(void* ptr, int bytes, int rowLength);

void mem_dump(void* pointer, int bytes, int rowLength) {
    char * ptr = pointer;
    int i;
    for (i = 0; i < bytes; i++) {
        if (i % rowLength == 0) {
            printf("\n%p    ", &ptr);
        }
        printf("%02hhx ", *ptr);
        *ptr++;
    }
}

int main(int argc, char** argv) {
    char *text = "I love to break free";
    mem_dump(text, strlen(text) + 1, 5);

    printf("\n");
    int array[] = {7, 3, 2, 10, -5};
    size_t size = sizeof (array) / sizeof (int);
    mem_dump(array, size * sizeof (int), 4);

    return (EXIT_SUCCESS);
}

