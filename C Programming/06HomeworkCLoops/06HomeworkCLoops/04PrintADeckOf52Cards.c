
#include <stdio.h>
#include <stdlib.h>

char ChooseSuit(int number);
char ChooseCard(int number);

int main(int argc, char** argv) {
    int i;
    for (i = 2; i < 15; i++) {
        int j;
        for (j = 0; j < 4; j++) {
            if(i < 11){
                printf("%d%c ",i,ChooseSuit(j));
            }
            else{
                printf("%c%c ",ChooseCard(i),ChooseSuit(j));
            }
        }
        printf("\n");

    }
    return (EXIT_SUCCESS);
}

char ChooseSuit(int number) {
    switch (number) {
        case 0: return 'C';
        case 1: return 'D';
        case 2: return 'H';
        case 3: return 'S';
        default: return ' ';
    }
}

char ChooseCard(int number) {
    switch (number) {
        case 11: return 'J';
        case 12: return 'Q';
        case 13: return 'K';
        case 14: return 'A';
        default: return ' ';
    }
}
