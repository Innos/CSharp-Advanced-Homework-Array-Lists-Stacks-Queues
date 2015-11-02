

#include <stdio.h>
#include <stdlib.h>

void swap(void* ptr1, void* ptr2, size_t size);

void swap(void* ptr1, void* ptr2, size_t size) {
    char * a = ptr1;
    char * b = ptr2;
    int i;
    for (i = 0; i < size; i++) {
        char temp = *(a + i);
        *(a + i) = *(b + i);
        *(b + i) = temp;
    }
}

int main(int argc, char** argv) {
    char letter = 'B', symbol = '+';
    swap(&letter, &symbol, sizeof (char));
    printf("%c %c\n", letter, symbol);

    int a = 10, b = 6;
    swap(&a, &b, sizeof (int));
    printf("%d %d\n", a, b);

    double d = 3.14, f = 1.23567;
    swap(&d, &f, sizeof (double));
    printf("%.2f %.2f\n", d, f);
    return (EXIT_SUCCESS);
}

