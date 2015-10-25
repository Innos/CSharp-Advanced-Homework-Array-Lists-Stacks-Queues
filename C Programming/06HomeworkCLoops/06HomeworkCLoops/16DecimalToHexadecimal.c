
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    char hexadecimal[64];
    memset(hexadecimal,0,sizeof hexadecimal);
    long n;
    scanf("%li", &n);
    long number = n; 
    int i = 0;
    while (number != 0) {
        int temp = number % 16;
        if (temp < 10) {
            temp = temp + 48;
        } else {
            temp = temp + 55;
        }
        hexadecimal[i++] = temp;
        number = number / 16;
    }
    int len = strlen(hexadecimal);
    int j;
    for(j = len-1;j>=0;j--){
        printf("%c",hexadecimal[j]);
    }
    return (EXIT_SUCCESS);
}

