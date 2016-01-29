function findYoungestPerson(arr){
    var youngest;
    var min = Number.MAX_VALUE;
    arr.forEach(function(el){
        if(el.age < min && el.hasSmartphone)
        {
            youngest = el;
            min = el.age;
        }
    });
    return youngest;
}

var people = [
    { firstname : 'George', lastname: 'Kolev', age: 32, hasSmartphone: false },
    { firstname : 'Vasil', lastname: 'Kovachev', age: 40, hasSmartphone: true },
    { firstname : 'Bay', lastname: 'Ivan', age: 81, hasSmartphone: true },
    { firstname : 'Baba', lastname: 'Ginka', age: 40, hasSmartphone: false }]


console.log(findYoungestPerson(people));