function replaceATag(str){
    var regex = /<a(.*)>(.*)<\/a>/g;
    var newString = str.replace(regex,"[URL$1]$2[/URL]");
    return newString;
}

var str2 = "<ul>\n    <li>\n       <a href=http://softuni.bg>SoftUni</a>\n    </li>\n</ul>"
console.log(replaceATag(str2));

