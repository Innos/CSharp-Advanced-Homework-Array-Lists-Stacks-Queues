

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    char card[5];
    memset(card, 0, sizeof card);
    fgets(card, sizeof card, stdin);
    int lastElement = strlen(card) - 1;
    if(card[lastElement] == '\n'){
        card[lastElement] = '\0';
    }
    if (strlen(card) > 2) {
        printf("no");
    } else {
        switch (card[0]) {
            case '1':
                if (card[1] == '0') {
                    printf("yes");
                } else {
                    printf("no");
                }
                break;
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
            case 'J':
            case 'Q':
            case 'K':
            case 'A':
                printf("yes");
                break;
            default:
                printf("no");
                break;
        }
    }
    return (EXIT_SUCCESS);
}

