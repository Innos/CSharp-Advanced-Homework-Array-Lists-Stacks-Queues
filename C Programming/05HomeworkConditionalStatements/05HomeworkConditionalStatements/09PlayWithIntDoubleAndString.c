
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    printf("Please choose a type:\n1 --> int\n2 --> double\n3 --> string:");
    char choice;
    // %*c reads and discards the next char, in this case the \n
    scanf("%c%*c", &choice);
    switch (choice) {
        case '1': printf("Please enter an int:");
            int a;
            scanf("%d", &a);
            printf("%d", a + 1);
            break;
        case '2': printf("Please enter a double:");
            double b;
            scanf("%lf", &b);
            printf("%f", b + 1);
            break;
        case '3': printf("Please enter a string:");
            char string[50];
            fgets(string, sizeof string, stdin);
            int lastElement = strlen(string) -1;
            string[lastElement] = '*';
            printf("%s", string);
            break;
    }
    return (EXIT_SUCCESS);
}

