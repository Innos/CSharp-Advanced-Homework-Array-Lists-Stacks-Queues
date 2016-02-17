function testContext(){
    console.log(this);
}

// from global scope returns the global object
testContext();
console.log();

function test()
{
    // from a function returns the closest parent object if not called as a member of an object in the parent function,
    // then this is the parent of the parent function i.e. in this context the global object
    testContext();
    console.log();

    // here we call it as a method of an object in the parent function, thus this will point to obj
    var obj = {method:testContext};
    obj.method();
    console.log();
}

test();

//returns objTest, using the function as a constructor means objTest will be an object which inherits from testContext.prototype
var objTest = new testContext();
