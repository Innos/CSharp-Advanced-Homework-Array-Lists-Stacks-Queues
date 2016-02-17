Array.prototype.flatten = function flatten(){
    var newArray = [];

    function iterate(array){
        array.forEach(function (el){
            if(!(el instanceof Array)){
                newArray.push(el);
            }
            else{
                iterate(el);
            }
        })
    }
    iterate(this);
    return newArray;
};

var array = [1, 2, 3, 4];
console.log(array.flatten());
console.log();

var array = [1, 2, [3, 4], [5, 6]];
console.log(array.flatten());
console.log(array);
console.log();

var array = [0, ["string", "values"], 5.5, [[1, 2, true], [3, 4, false]], 10];
console.log(array.flatten());


