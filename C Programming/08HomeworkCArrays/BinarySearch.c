

int BinarySearchIterative(int* numbers, int size, int element) {
    int start = 0;
    int end = size - 1;
    while (start <= end) {
        int mid = (start + end) / 2;
        if(numbers[mid] == element){
            return mid;
        }
        else if(numbers[mid] > element){
            end = mid-1;
        }
        else if(numbers[mid] < element){
            start = mid+1;
        }
    }
    return -1;
}

int BinarySearchRecursive(int* numbers,int start,int end,int element){
    if(start > end){
        return -1;
    }
    int mid = (start+end)/2;
    if(numbers[mid] == element){
        return mid;
    }
    else if(numbers[mid] > element){
        BinarySearchRecursive(numbers,start,mid-1,element);
    }
    else if(numbers[mid] < element){
        BinarySearchRecursive(numbers,mid+1,end,element);
    }
}
