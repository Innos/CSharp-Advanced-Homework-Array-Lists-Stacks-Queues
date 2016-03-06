
var arr ='[{"manufacturer":"BMW","model":"E92 320i","year":2011,"price":50000,"class":"Family"},' +
    '{"manufacturer":"Porsche","model":"Panamera","year":2012,"price":100000,"class":"Sport"},' +
    '{"manufacturer":"Peugeot","model":"305","year":1978,"price":1000,"class":"Family"}]';



var items = $.parseJSON(arr);
var table = $("<table>");
var head = $("<thead>");

for(var key in items[0]){
    var uppercaseKey = key.charAt(0).toUpperCase() + key.slice(1);
    var collumn = $("<th>").text(uppercaseKey);
    head.append(collumn);
}
table.append(head);
items.forEach(function(el){
    var row = $("<tr>");
    for(var key in el){
        var td = $("<td>").text(el[key]);
        row.append(td);
    }
    table.append(row);
});
$("#wrapper").append(table);