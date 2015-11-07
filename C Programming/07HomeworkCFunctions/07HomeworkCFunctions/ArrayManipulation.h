#include <stdio.h>
#include <stdbool.h>

#ifndef ARRAYMANIPULATION_H
#define	ARRAYMANIPULATION_H

int arr_min(int* array, size_t size);
int arr_max(int* array, size_t size);
void arr_clear(int* array, size_t size);
double arr_average(int* array, size_t size);
long arr_sum(int * array, size_t size);
bool arr_contains(int* array, size_t size, int element);
int* arr_merge(int* array1, size_t size1, int* array2, size_t size2);
#endif	/* ARRAYMANIPULATION_H */

