
var add = function add(){

    var sum = 0;

    function inner(x)
    {
        sum += x;
        return inner;
    }


    inner.toString = function (){
        return sum;
    };

    return inner;

}();



console.log(+add(1)(2)(3));
