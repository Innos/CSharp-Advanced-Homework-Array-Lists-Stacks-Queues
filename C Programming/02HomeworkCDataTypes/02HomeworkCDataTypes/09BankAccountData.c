
#include <stdio.h>
#include <stdlib.h>


int main() {
    char firstName[] = "Pesho";
    char middleName[] = "Peshev";
    char lastName[] = "Peshev";
    long double balance = 100.2555555;
    char bankName[] = "Pesho's Bank";
    char IBAN[] = "PSHO 9999 9999 9999 9999";
    long long card1Number = 0000000000001;
    long long card2Number = 0000000000002;
    long long card3Number = 0000000000003;
    
    printf("Name: %s %s %s\n",firstName,middleName,lastName);
    printf("Balance: %Lf\n",balance);
    printf("Bank name: %s\n",bankName);
    printf("IBAN: %s\n",IBAN);
    printf("Card 1: %lli\n",card1Number);
    printf("Card 2: %lli\n",card2Number);
    printf("Card 2: %lli\n",card3Number);
      
    return (EXIT_SUCCESS);
}

