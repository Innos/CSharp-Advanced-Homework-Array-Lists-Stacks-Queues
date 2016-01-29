function extractObjects(arr){
    var result = [];
    for(i =0; i < arr.length; i++)
    {
        if(typeof(arr[i]) === 'object' && arr[i].constructor !== Array)
        {
            result.push(arr[i]);
        }
    }
    return result;
}

var array = [
    "Pesho",
    4,
    4.21,
    { name : 'Valyo', age : 16 },
    { type : 'fish', model : 'zlatna ribka' },
    [1,2,3],
    "Gosho",
    { name : 'Penka', height: 1.65}
];

console.log(extractObjects(array));
