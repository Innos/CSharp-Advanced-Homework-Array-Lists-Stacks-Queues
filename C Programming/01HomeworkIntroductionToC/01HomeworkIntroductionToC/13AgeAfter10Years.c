
#include <stdio.h>
#include <stdlib.h>
#include <time.h>


int main() {    
    time_t t = time(NULL);
    struct tm tm = *localtime(&t);
    int cYear = tm.tm_year+1900;
    int cMonth = tm.tm_mon+1;
    int cDay = tm.tm_mday;
    int yoB,moB,doB;
    scanf("%d.%d.%d",&doB,&moB,&yoB);
    int years = cYear - yoB;
    if(cMonth<moB){
        years--;
    }
    else if(cMonth == moB && cDay < doB){
        years--;
    }
    
    printf("Now: %d\n",years);
    printf("After 10 years: %d\n",years + 10);
    return 0;
}

