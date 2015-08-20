module Utils{
	export class Formatter{
		displayText(message:string){
			console.log("########");
			console.log(message);
			console.log("########");
		}
	}
}

var utils = new Utils.Formatter;
utils.displayText("Hello");