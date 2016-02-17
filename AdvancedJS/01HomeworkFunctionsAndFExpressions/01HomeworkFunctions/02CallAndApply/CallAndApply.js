function printArgsInfo(){
    for(var i = 0;i<arguments.length;i++)
    {
        var type = typeof (arguments[i]);
        if(Array.isArray(arguments[i]))
        {
            type = "array";
        }
        console.log(arguments[i] + "(" + type + ") ");
    }
}

printArgsInfo.call(this);
console.log();
printArgsInfo.call(this,2, 3, 2.5, -110.5564, false);

printArgsInfo.apply(this,[]);
console.log();
printArgsInfo.apply(this,[2, 3, 2.5, -110.5564, false]);
console.log();

