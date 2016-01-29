function clone(source) {
    var destination  = new Object();
    for (var property in source) {
        if (typeof source[property] === "object" && source[property] !== null && destination[property]) {
            clone(destination[property], source[property]);
        } else {
            destination[property] = source[property];
        }
    }
    return destination;
};

function compareObjects(a,b){
    return a==b;
}

var a = {name: 'Pesho', age: 21}
var b = clone(a); // a deep copy
console.log("a == b --> " + compareObjects(a, b));
console.log(b);
