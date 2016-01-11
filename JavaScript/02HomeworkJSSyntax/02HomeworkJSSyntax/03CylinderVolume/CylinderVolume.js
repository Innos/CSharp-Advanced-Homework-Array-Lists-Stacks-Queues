var args = process.argv.slice(2);

var volume = calcCylinderVol(args);
console.log(volume.toFixed(3));

function calcCylinderVol(arr)
{
    var radius = arr[0];
    var height = arr[1];
    return Math.PI * radius * radius * height;
}
