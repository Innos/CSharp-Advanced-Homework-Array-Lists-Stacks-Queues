
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

typedef struct Client {
    char * name;
    int age;
    double balance;
} Client;

int age_comparator(Client a, Client b);
int balance_comparator(Client a, Client b);
int name_comparator(Client a, Client b);
void Sort(Client * clients, size_t count, int (*func) (Client, Client));
void Print(Client * clients, size_t count);

int age_comparator(Client a, Client b) {
    return a.age - b.age;
}

int balance_comparator(Client a, Client b) {
    if (a.balance > b.balance) {
        return 1;
    } else if (a.balance < b.balance) {
        return -1;
    } else {
        return 0;
    }
}

int name_comparator(Client a, Client b) {
    return strcmp(a.name, b.name);
}

void InsertionSort(Client * clients, size_t count, int (*func) (Client, Client)) {
    int i;
    for (i = 1; i < count; i++) {
        int j = i;
        while (j > 0 && (*func)(clients[j - 1], clients[j]) > 0) {
            Client temp = clients[j - 1];
            clients[j - 1] = clients[j];
            clients[j] = temp;
            j--;
        }
    }
}

void Print(Client * clients, size_t count) {
    int i;
    for (i = 0; i < count; i++) {
        printf("Name: %s; Age: %d; Balance: %.2f;\n", clients[i].name, clients[i].age, clients[i].balance);
    }
}

int main(int argc, char** argv) {
    struct Client client1;
    struct Client client2;
    struct Client client3;

    client1.name = "Pesho";
    client1.age = 20;
    client1.balance = 55.70;

    client2.name = "Gosho";
    client2.age = 35;
    client2.balance = 1337;

    client3.name = "Ivan";
    client3.age = 25;
    client3.balance = 0.01;

    struct Client clients[] = {client1, client2, client3};

    size_t count = sizeof (clients) / sizeof (clients[0]);
    printf("Original:\n");
    Print(clients, count);
    printf("Sorted by age:\n");
    InsertionSort(clients, count, &age_comparator);
    Print(clients, count);
    printf("Sorted by name:\n");
    InsertionSort(clients, count, &name_comparator);
    Print(clients, count);
    printf("Sorted by balance:\n");
    InsertionSort(clients, count, &balance_comparator);
    Print(clients, count);

    return (EXIT_SUCCESS);
}

