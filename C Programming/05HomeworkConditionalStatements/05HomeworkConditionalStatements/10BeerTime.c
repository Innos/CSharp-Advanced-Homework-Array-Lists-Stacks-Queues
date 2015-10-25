

#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(int argc, char** argv) {
    int hour, min;
    char format[4];
    memset(format, 0, sizeof format);
    
    scanf("%d:%d %s", &hour, &min, &format);
    format[3] = '\0';
    //check for invalid input
    if (hour < 1 || hour > 12 || min < 0 || min > 59 || !(strcmp(format, "AM") == 0 || strcmp(format, "PM") == 0)) {
        printf("invalid time");
    } else {
        if (strcmp(format, "PM") == 0) {
            hour += 12;
        }
        if (hour >= 3 && hour < 13) {
            printf("non-beer time");
        } else {
            printf("beer time");
        }
    }
    return (EXIT_SUCCESS);
}

