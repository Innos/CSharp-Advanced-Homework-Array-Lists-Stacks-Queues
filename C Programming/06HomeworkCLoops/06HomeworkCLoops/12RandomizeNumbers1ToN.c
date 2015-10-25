
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int main(int argc, char** argv) {
    int n;
    scanf("%d", &n);
    int used[n];
    memset(used, 0, sizeof used);
    srand(time(NULL));
    int i;
    for (i = 0; i < n; i++) {
        int random = rand() % n;
        while (used[random] != 0) {
            random = rand() % n;
        }
        printf("%d ", random + 1);
        used[random] = 1;
    }
    return (EXIT_SUCCESS);
}

