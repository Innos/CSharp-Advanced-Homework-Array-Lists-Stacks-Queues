

#include <stdio.h>
#include <stdlib.h>

void Print(int num);

void Print(int num)
{
    printf("%p\n",num);
}

int main(int argc, char** argv) {
    int num1;
    scanf("%d",&num1);
    Print(&num1);
    // the addresses are different because we're sending a value type so another int is created with the same value
    // on the stack
    printf("%p",&num1);
    return (EXIT_SUCCESS);
}

