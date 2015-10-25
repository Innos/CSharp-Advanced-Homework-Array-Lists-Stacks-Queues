
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(int argc, char** argv) {
    size_t size = 0;
    char* line = NULL;
    if (getline(&line, &size, stdin) != -1) {
        if (line[size - 1] == '\n') {
            line[size - 1] = '\0';
        }
        long productEven = 1;
        long productOdd = 1;
        int counter = 1;
        char* num = strtok(line, " ");
        while (num != NULL) {
            if (counter % 2 == 0) {
                productEven *= strtol(num, NULL, 10);
            } else {
                productOdd *= strtol(num, NULL, 10);
            }
            num = strtok(NULL, " ");
            counter++;
        }
        if (productEven == productOdd) {
            printf("yes\n");
            printf("product = %li\n", productEven);
        } else {
            printf("no\n");
            printf("odd_product = %li\n", productOdd);
            printf("even_product = %li\n", productEven);
        }
    }
    free(line);
    return (EXIT_SUCCESS);
}

