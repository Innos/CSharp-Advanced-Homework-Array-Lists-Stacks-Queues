
#include <stdio.h>
#include <stdlib.h>

//this is actually all the ways we can take k items out of n items
int main(int argc, char** argv) {
    int n, k;
    scanf("%d %d", &n, &k);
    long sum = 1;
    int i;
    for (i = n; i > k; i--) {
        sum = sum * i;
    }
    printf("%li",sum);
    return (EXIT_SUCCESS);
}

