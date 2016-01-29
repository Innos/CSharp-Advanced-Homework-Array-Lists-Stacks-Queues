var arr = [{'name' : 'Пешо', 'score' : 91}, {'name' : 'Лилия', 'score' : 290},
    {'name' : 'Алекс', 'score' : 343}, {'name' : 'Габриела', 'score' : 400}, {'name' : 'Жичка', 'score' : 70}];

arr.forEach(function(obj){
    obj.score = +(obj.score * 1.10).toFixed(1);
    obj['hasPassed'] =  obj.score > 99 ? 'True' : 'False';
});

arr = arr.filter(function(value,index, arr){
    if(value.score > 99){
        return true;
    }
    return false;
});

arr = arr.sort(function (a,b){return a.name.localeCompare(b.name)});

console.log(arr);