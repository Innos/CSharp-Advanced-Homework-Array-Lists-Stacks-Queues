
#include <stdio.h>
#include <stdlib.h>

size_t StringLength(char* string);

size_t StringLength(char* string){
    size_t size = 0;
    char ch = *string;
    while(ch != '\0'){
        size++;
        ch = *++string;
    }
    return size;
}

int main(int argc, char** argv) {
    char buffer[10] = {'C','\0','B','a','b','y'};
    char buffer2[] = { 'D', 'e', 'r', 'p', '\0' };

    size_t count1 = StringLength("Soft");
    size_t count2 = StringLength("SoftUni");
    size_t count3 = StringLength(buffer);
    size_t count4 = StringLength(buffer2);
    
    printf("%lu\n",count1);
    printf("%lu\n",count2);
    printf("%lu\n",count3);
    printf("%lu\n",count4);
    
    return (EXIT_SUCCESS);
}

