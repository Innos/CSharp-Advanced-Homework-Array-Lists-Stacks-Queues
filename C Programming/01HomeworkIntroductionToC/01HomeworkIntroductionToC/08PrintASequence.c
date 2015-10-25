
#include <stdio.h>
#include <stdlib.h>

int main() {
    int i,roof;
    int start = 2;
    scanf("%d",&roof);
    for(i= 2;i<start + roof;i++){
        if(i % 2 == 0){   
            printf("%d, ",i);
        }
        else{
            printf("%d, ",-i);
        }
    }
    return 0;
}

