

#include <stdio.h>
#include <stdlib.h>

int new_integer()
{
    int a = 5;
    return a;
}

// returns a pointer to a now garbage memory, any information there is not safe
int* new_integer_ptr(){
    int a = 5;
    int *ptr = &a;
    return ptr;
}
int main(int argc, char** argv) {
    int a = new_integer();
    int * b = new_integer_ptr();
    printf("%d %d\n",a,*b);
    printf("Oh look b mutated because I overwrote the memory it points to.\n");
    printf("%d %d",a,*b);

    return (EXIT_SUCCESS);
}

