var message1 = function (message) {
    console.log("message 1" + message);
};
var message2 = function (message) {
    console.log("message 1" + message);
};
var items = [];
items.push(message1);
items.push(message2);
var length = items.length;
var i = 0;
while(i < length) {
    items[i]("hello");
    i++;
}
