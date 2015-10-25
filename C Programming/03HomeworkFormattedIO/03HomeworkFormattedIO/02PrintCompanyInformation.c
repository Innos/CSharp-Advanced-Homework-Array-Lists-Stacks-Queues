
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

char* readFromIn();

int main() {
    printf("Write all parameters each on a new line:");
    char* companyName = readFromIn();
    char* companyAddress = readFromIn();
    char* phoneNumber = readFromIn();
    char* faxNumber = readFromIn();
    char* website = readFromIn();
    char* managerFirstName = readFromIn();
    char* managerLastName = readFromIn();
    char* managerAge = readFromIn();
    char* managerPhone = readFromIn();
    
    printf("%s\n", companyName);
    printf("Address: %s\n", companyAddress);
    printf("Tel. %s\n",phoneNumber);
    printf("Fax: %s\n",faxNumber);
    printf("Web site: %s\n",website);
    printf("Manager: %s %s (age: %s, tel. %s)\n",managerFirstName,managerLastName,managerAge,managerPhone);
    return (EXIT_SUCCESS);
}

char* readFromIn() {
    char* text = malloc(100);
    if (fgets(text, 100, stdin) != NULL) {
        int textLen = strlen(text);
        if(textLen > 0 && text[textLen - 1] == '\n'){
            text[textLen - 1] = '\0';
        }
        return text;
    }
    else{
        free(text);
        return NULL;
    }

}

