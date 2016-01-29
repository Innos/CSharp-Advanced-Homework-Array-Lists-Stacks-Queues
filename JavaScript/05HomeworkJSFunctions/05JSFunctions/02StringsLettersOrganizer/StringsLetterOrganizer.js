function sortLetters(string, ascending){
    var result;
    if(ascending)
    {
        result = string.split('').sort(caseInsensitiveCompare).join('');
    }
    else{
        result = string.split('').sort(caseInsensitiveCompareDescending).join('');
    }
    return result;
}

function caseInsensitiveCompare(a,b){
    var compare = a.toLowerCase().localeCompare(b.toLowerCase());
    if(compare !== 0)
    {
        return compare;
    }

    if(a > b){
        return 1;
    }
    else if(a < b){
        return -1;
    }
    else{
        return 0;
    }
}

function caseInsensitiveCompareDescending(a,b)
{
    return caseInsensitiveCompare(b,a);
}

console.log(sortLetters('HelloWorld',true));
console.log(sortLetters('HelloWorld',false));
