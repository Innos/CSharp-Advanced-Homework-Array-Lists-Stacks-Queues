

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

int main(int argc, char** argv) {
    long num, position;
    scanf("%li %li", &num, &position);

    bool isOne = (num >> position) & 1;
    printf("%s", isOne ? "True" : "False");
    return (EXIT_SUCCESS);
}

