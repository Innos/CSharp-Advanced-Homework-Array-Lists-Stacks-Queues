var arr = ["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined, 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]];

function filterNumbers (value, index, arr)
{
    if(Number(value)|| Number(value) === 0)
    {
        return true;
    }
    return false;
}

arr = arr.filter(filterNumbers);

var min = Math.min.apply(null, arr),
    max = Math.max.apply(null, arr);

counter = {}

arr.forEach(function(num) {
    var key = JSON.stringify(num)
    counter[key] = (counter[key] || 0) + 1
})

function getSortedKeys(obj) {
    var keys = [];
    for(var key in obj){
        keys.push(key);
    }
    return keys.sort(function(a,b){return obj[b]-obj[a]});
}

var keys = getSortedKeys(counter);

arr = arr.sort(function(a,b){return b-a;});
console.log("Sorted Array: " + arr);
console.log("Min: " + min);
console.log("Max: " + max);
console.log("Most frequent: " + keys[0]);