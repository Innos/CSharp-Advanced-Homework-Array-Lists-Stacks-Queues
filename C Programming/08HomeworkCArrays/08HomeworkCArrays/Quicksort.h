

#ifndef QUICKSORT_H
#define	QUICKSORT_H

void Quicksort(int* numbers, int start, int end);
void QuicksortLong(long* numbers, int start, int end);
int Partition(int * numbers, int start, int end);
int PartitionLong(long* numbers, int start, int end);
void Swap(int* numbers, int indexA, int indexB);
void SwapLong(long* numbers, int indexA, int indexB);


#ifdef	__cplusplus
extern "C" {
#endif




#ifdef	__cplusplus
}
#endif

#endif	/* QUICKSORT_H */

