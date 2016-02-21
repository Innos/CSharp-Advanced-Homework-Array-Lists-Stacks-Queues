function Person(firstName, lastName, age)
{
    return{
        firstName: firstName,
        lastName : lastName,
        age: age
    }
}

var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];


Array.prototype.groupBy = function(prop) {
    var groups = {};
    this.forEach(function(el) {
        var key = el[prop];
        if (key in groups == false) {
            groups[key] = [];
        }
        groups[key].push(el);
    });
    return groups;
};

function print(obj){
	for(var prop in obj)
	{
		obj[prop].forEach(function(el){
			console.log(el);
		})
	}
    
}

var result = people.groupBy('firstName');
var result2 = people.groupBy('lastName');
var result3 = people.groupBy('age');

console.log('------ By FirstName ------');
print(result);
console.log('------ By LastName ------');
print(result2);
console.log('------ By Age ------');
print(result3);



