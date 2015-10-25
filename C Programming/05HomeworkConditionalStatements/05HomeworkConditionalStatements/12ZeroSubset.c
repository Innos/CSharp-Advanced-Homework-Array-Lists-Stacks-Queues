

#include <stdio.h>
#include <stdlib.h>
static const int target = 0;
static int numbers[5];
static int result[5];
static int roof = sizeof (numbers) / sizeof (int);
static int usedNumbers = 0;
static int hasAnswer = 0;

void FindSubsets(int currentElement, int currentSum);

int main(int argc, char** argv) {
    scanf("%d %d %d %d %d", &numbers[0], &numbers[1], &numbers[2], &numbers[3], &numbers[4]);

    int n1;
    for (n1 = 0; n1 < 5; n1++) {
        int sum1 = numbers[n1];
        if (sum1 == 0) {
            printf("%d = 0\n", numbers[n1]);
        }
        int n2;
        for (n2 = n1 + 1; n2 < 5; n2++) {
            int sum2 = sum1 + numbers[n2];
            if (sum2 == 0) {
                printf("%d + %d = 0\n", numbers[n1], numbers[n2]);
                hasAnswer = 1;
            }
            int n3;
            for (n3 = n2 + 1; n3 < 5; n3++) {
                int sum3 = sum2 + numbers[n3];
                if (sum3 == 0) {
                    printf("%d + %d + %d = 0\n", numbers[n1], numbers[n2], numbers[n3]);
                    hasAnswer = 1;
                }
                int n4;
                for (n4 = n3 + 1; n4 < 5; n4++) {
                    int sum4 = sum3 + numbers[n4];
                    if (sum4 == 0) {
                        printf("%d + %d + %d + %d = 0\n", numbers[n1], numbers[n2], numbers[n3], numbers[n4]);
                        hasAnswer = 1;
                    }
                    int n5;
                    for (n5 = n4 + 1; n5 < 5; n5++) {
                        int sum5 = sum4 + numbers[n5];
                        if (sum5 == 0) {
                            printf("%d + %d + %d + %d + %d = 0\n", numbers[n1], numbers[n2], numbers[n3], numbers[n4], numbers[n5]);
                            hasAnswer = 1;
                        }
                    }
                }
            }
        }
    }
    //FindSubsets(0, 0);
    if (!hasAnswer) {
        printf("no zero subset");
    }
    return (EXIT_SUCCESS);
}

// recursive solution

void FindSubsets(int currentElement, int currentSum) {
    if (currentSum == target && usedNumbers != 0) {
        int i;
        for (i = 0; i < usedNumbers - 1; i++) {
            printf("%d + ", result[i]);
        }
        printf("%d = 0\n", result[i]);
        hasAnswer = 1;
    }
    int i;
    for (i = currentElement; i < roof; i++) {
        result[usedNumbers] = numbers[i];
        usedNumbers++;
        currentSum += numbers[i];
        FindSubsets(i + 1, currentSum);
        currentSum -= numbers[i];
        usedNumbers--;
        result[usedNumbers] = 0;

    }
}

