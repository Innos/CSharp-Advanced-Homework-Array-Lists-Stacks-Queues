function Person(firstName, lastName) {
    this.firstName = firstName;
    this.lastName = lastName;

    Object.defineProperty(this,"fullName",{
        get: function(){
            return this.firstName + " " + this.lastName;
        },
        set: function(newName){
            var parameters = newName.split(" ");
            this.firstName = parameters[0];
            this.lastName = parameters[1];
        }
    });
}


var person = new Person("Peter", "Jackson");

console.log(person.firstName);
console.log(person.lastName);
console.log(person.fullName);
console.log();

person.firstName = "Michael";
console.log(person.firstName);
console.log(person.fullName);
person.lastName = "Williams";
console.log(person.lastName);
console.log(person.fullName);
console.log();

person.fullName = "Alan Marcus";
console.log(person.fullName);
console.log(person.firstName);
console.log(person.lastName);


