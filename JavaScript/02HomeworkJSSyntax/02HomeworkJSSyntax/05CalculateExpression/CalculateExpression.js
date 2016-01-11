
function evaluateExpression()
{
    var expression = document.getElementById('input').value;
    var result = eval(expression);
    document.getElementById('result').innerHTML = result;
}
