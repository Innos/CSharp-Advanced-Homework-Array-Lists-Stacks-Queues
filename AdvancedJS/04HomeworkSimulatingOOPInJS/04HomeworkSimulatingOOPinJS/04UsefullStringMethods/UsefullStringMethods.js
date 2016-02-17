String.prototype.startsWith = function startsWith(substring){
    if(substring.length > this.length){
        return false;
    }
    for(var i = 0;i < substring.length;i++){
        if(this[i] !== substring[i]){
            return false;
        }
    }
    return true;
};

String.prototype.endsWith = function endsWith(substring){
    if(substring.length > this.length){
        return false;
    }
    for(var i = 0,end = this.length - substring.length;i < substring.length;i++,end++){
        if(this[end] !== substring[i]){
            return false;
        }
    }
    return true;
};

String.prototype.left = function left(count){
    if(count > this.length){
        return this.toString();
    }
    return this.substring(0,count);
};

String.prototype.right = function left(count){
    var len = this.length;
    if(count > len){
        return this.toString();
    }
    return this.substring(len-count);
};

String.prototype.repeat = function repeat(count){

    var result = "";
    for(var i = 0;i<count;i++){
        result += this;
    }
    return result;
};

String.prototype.padLeft = function padLeft(count,character){
    character = character || " ";
    var len = this.length;
    if(count <= len){
        return this.toString();
    }
    var times = count - len;
    return character.repeat(times) + this;
};

String.prototype.padRight = function padRight(count,character){
    character = character || " ";
    var len = this.length;
    if(count <= len){
        return this.toString();
    }
    var times = count - len;
    return this + character.repeat(times);
};

var str = "whatupdawg";

console.log(str.startsWith("what"));
console.log(str.endsWith("updawg"));
console.log();

var example = "This is an example string used only for demonstration purposes.";
console.log(example.left(9));
console.log(example.left(90));
console.log();

console.log(example.right(9));
console.log(example.right(90));
console.log();

var hello = "hello";
console.log(hello.padLeft(5));
console.log(hello.padLeft(10));
console.log(hello.padLeft(5, "."));
console.log(hello.padLeft(10, "."));
console.log(hello.padLeft(2, "."));
console.log();

console.log(hello.padRight(5));
console.log(hello.padRight(10));
console.log(hello.padRight(5, "."));
console.log(hello.padRight(10, "."));
console.log(hello.padRight(2, "."));
console.log();

var character = "*";
console.log(character.repeat(5));
// Alternative syntax
console.log("~".repeat(3));
console.log();

// Another combination
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));



