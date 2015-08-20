function displayNames(names) {
    var i = 0, length = names.length;
    for(i = 0; i < length; i++) {
        console.log(names[i].toUpperCase());
    }
    ;
}
var data = [
    'my', 
    'name', 
    'is', 
    'vijayant', 
    'katyal'
];
displayNames(data);
