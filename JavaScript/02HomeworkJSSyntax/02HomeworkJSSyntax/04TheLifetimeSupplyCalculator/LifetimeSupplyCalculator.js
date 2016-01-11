var args = process.argv.slice(2);

var age = Number(args[0]);
var maxAge = Number(args[1]);
var food = args[2];
var foodPerDay = Number(args[3]);

var totalSupply = calcSupply(age,maxAge,food,foodPerDay);

console.log(totalSupply + "kg of " + food + " would be enough until I am " + maxAge + " years old.")

function calcSupply(age, maxAge, food, foodPerDay)
{
    var years = maxAge - age;
    var supply = years * 365 * foodPerDay;
    return supply;
}
