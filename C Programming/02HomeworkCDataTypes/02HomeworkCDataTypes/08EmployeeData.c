
#include <stdio.h>
#include <stdlib.h>


int main() {
    char firstName[] = "Amanda";
    char lastName[] = "Jonson";
    unsigned char age = 27;
    char gender = 'f';
    char personalID[] = "8306112507";
    long employeeNumber = 27563571;
    
    printf("First name: %s\n",firstName);
    printf("Last name: %s\n",lastName);
    printf("Age: %d\n",age);
    printf("Gender: %c\n",gender);
    printf("Personal ID: %s\n",personalID);
    printf("Unique Employee Number: %li\n",employeeNumber);
    
    return (EXIT_SUCCESS);
}

