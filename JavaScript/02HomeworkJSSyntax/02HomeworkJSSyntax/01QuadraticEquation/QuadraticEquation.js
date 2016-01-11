
var a = prompt("enter value of a");
var b = prompt("enter value of b");
var c = prompt("enter value of c");

var discriminant = (b * b) - (4 * a * c);
if(discriminant < 0)
{
    console.log("No real roots");
}
else if(discriminant === 0)
{
    var solution = -b/(2*a);
    console.log("X = " + solution);
}
else{
    var solution1 = ((-b + (Math.sqrt(discriminant))) / (2 * a));
    var solution2 = ((-b - (Math.sqrt(discriminant))) / (2 * a));
    console.log("X1 = " + solution1);
    console.log("X2 = " + solution2);
}

