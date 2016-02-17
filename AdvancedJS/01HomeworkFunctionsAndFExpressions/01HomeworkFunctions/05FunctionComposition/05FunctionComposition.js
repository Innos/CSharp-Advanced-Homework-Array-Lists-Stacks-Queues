var compose = function compose(){
    //get all the functions with the arguments array
    var functions = arguments;
    return function executeFunctions(){
        //get parameters for first function with the arguments array
        var args = arguments;
        for(var i = functions.length - 1; i >= 0;i--)
        {
            //the result of the first function is used as arguments for the second and so on
            args = [functions[i].apply(this,args)];
        }
        return args[0];
    }
}

function add(x, y) {
    return x + y;
}
function addOne(x) {
    return x + 1;
}
function square(x) {
    return x * x;
}

console.log(compose(addOne,square)(5));

console.log(compose(addOne, add)(5, 6));

console.log(compose(Math.cos, addOne)(-1));

console.log(compose(addOne, Math.cos)(-1));

console.log(compose(Math.sqrt,Math.cos)(0.5));
console.log(compose(Math.sqrt,Math.cos)(1));
console.log(compose(Math.sqrt,Math.cos)(-1));