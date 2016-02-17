var Vector = (function () {
    function Vector(arr) {
        if(arr === undefined || arr.length === 0){
            throw new Error("Cannot create vector without dimensions!");
        }
        this.components = arr;
    }

    Vector.prototype.add = function(other){
        if(other.components.length !== this.components.length){
            throw new Error("Vectors do not have same dimensions!");
        }
        var newComponents = [];
        var len = this.components.length;
        for(var i = 0; i < len;i++){
            newComponents.push(this.components[i] + other.components[i]);
        }

        return new Vector(newComponents)
    };

    Vector.prototype.subtract = function(other){
        if(other.components.length !== this.components.length){
            throw new Error("Vectors do not have same dimensions!");
        }
        var newComponents = [];
        var len = this.components.length;
        for(var i = 0; i < len;i++){
            newComponents.push(this.components[i] - other.components[i]);
        }

        return new Vector(newComponents)
    };

    Vector.prototype.dot = function(other){
        if(other.components.length !== this.components.length){
            throw new Error("Vectors do not have same dimensions!");
        }
        var sum = 0;
        var len = this.components.length;
        for(var i = 0; i < len;i++){
            sum += this.components[i] * other.components[i];
        }

        return sum;
    };

    Vector.prototype.norm = function(){

        var sum = 0;
        var len = this.components.length;
        for(var i = 0; i < len;i++){
            sum += this.components[i] * this.components[i];
        }

        return Math.sqrt(sum);
    };

    Vector.prototype.toString = function(){
        return "(" + this.components.join(", ") + ")";
    };


    return Vector;
})();

var a = new Vector([1, 2, 3]);
var b = new Vector([4, 5, 6]);
var c = new Vector([1, 1, 1, 1, 1, 1, 1, 1, 1, 1]);
console.log(a.toString());
console.log(c.toString());

// The following throw errors
//var wrong = new Vector();
//var anotherWrong = new Vector([]);

console.log();

var result = a.add(b);
console.log(result.toString());
//a.add(c); // Error
console.log();

var result = a.subtract(b);
console.log(result.toString());

//a.subtract(c); // Error
console.log();

var result = a.dot(b);
console.log(result.toString());

//a.dot(c); // Error
console.log();

console.log(a.norm());
console.log(b.norm());
console.log(c.norm());
console.log(a.add(b).norm());




