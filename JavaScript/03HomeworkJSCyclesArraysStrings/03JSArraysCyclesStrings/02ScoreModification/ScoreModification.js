var arr = [200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1];

arr = arr.filter(function(value,index,arr){
    if(Number(value) > 400 || Number(value) < 0)
    {
        return false;
    }
    return true;
});

arr = arr.map(function(value){
    return +(value * 0.8).toFixed(1);
})
arr = arr.sort(function (a,b) {return a-b;})
console.log(arr);