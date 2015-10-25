

#include <stdio.h>
#include <stdlib.h>

int main() {
    int a;
    scanf("%d",&a);
    printf("%s",a % 2 == 0? "Even": "Odd");
    return (EXIT_SUCCESS);
}

