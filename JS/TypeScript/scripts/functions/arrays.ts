var message1 = ( message:string ) => { console.log("message1 " + message); }
var message2 = ( message:string ) => { console.log("message2 " + message); }

var items: { (message: string): void; }[] = []
items.push(message1)
items.push(message2);

var length = items.length;
var i = 0;

while(i<length){
	items[i]("hello");
	i++;
}