
void ReverseIntArray(int* numbers,int size);

void ReverseIntArray(int* numbers,int size){
    int start = 0;
    int end = size-1;
    while(start < end){
        int temp =numbers[start];
        numbers[start] = numbers[end];
        numbers[end] = temp;
        start++;
        end--;
    }
}
