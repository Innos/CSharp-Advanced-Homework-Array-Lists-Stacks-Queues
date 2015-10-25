
#include <stdio.h>
#include <stdlib.h>

long calculateSum(long number);
long reverse(long number);
long lastDigitFirst(long number);
long exchangeSecondAndThird(long number);

int main(int argc, char** argv) {
    long number;
    scanf("%li",&number);
    printf("Sum: %li\n",calculateSum(number));
    printf("Reversed: %li\n",reverse(number));
    printf("Last Digit First: %li\n",lastDigitFirst(number));
    printf("Exchanged second and third Digit: %li\n",exchangeSecondAndThird(number));
    return (EXIT_SUCCESS);
}

long calculateSum(long number){
    long sum = 0;
    while(number > 0){
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

long reverse(long number){
    long reverse = 0;
    reverse += (number  % 10) * 1000;
    reverse += ((number /10) % 10) * 100;
    reverse += ((number /100) % 10) * 10;
    reverse += (number /1000);
    return reverse;
}

long lastDigitFirst(long number){
    int lastDigit = number % 10;
    long updated = number /10 + lastDigit * 1000;
    return updated;
}

long exchangeSecondAndThird(long number){
    long exchanged = 0;
    int firstDigit = number / 1000;
    int secondDigit = (number /100) % 10;
    int thirdDigit = (number / 10) % 10;
    int fourthDigit = number % 10;
    exchanged = firstDigit * 1000 + thirdDigit * 100 + secondDigit * 10 + fourthDigit;
    return exchanged;
}

