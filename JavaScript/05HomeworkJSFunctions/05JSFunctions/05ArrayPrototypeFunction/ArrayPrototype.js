function removeItem(value){
    for(i=this.length;i>=0;i--)
    {
        if(this[i] === value)
        {
            this.splice(i,1);
        }
    }
}

Array.prototype.removeItem = removeItem;

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];
arr.removeItem(1);

var arr2 = ['hi', 'bye', 'hello' ];
arr2.removeItem('bye');

console.log(arr);
console.log(arr2);