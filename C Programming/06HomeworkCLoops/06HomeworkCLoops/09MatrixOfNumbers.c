
#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv) {
    int n;
    scanf("%d", &n);
    int i;
    for (i = 1; i <= n; i++) {
        int j = i;
        int roof = j + n;
        for (j; j < roof; j++) {
            printf("%d ",j);
        }
        printf("\n");
    }
    return (EXIT_SUCCESS);
}

