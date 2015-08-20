// simple function

function addTwoNumbers(number1: number,number2:number):number{
	console.log(number1 + number2);
	return number1 + number2;
}

// addTwoNumbers(10,20);

// lambda function

var add = (n1: number,n2: number):number =>{
	console.log(n1+n2);
	return n1 + n2;
}

// add(22,34);

// Declaring objects that hold a specific function type

var addAndLogicFunction: (n1:number,n2:number) => number;

addAndLogicFunction = addTwoNumbers;
addAndLogicFunction(10,32);

addAndLogicFunction = add;
addAndLogicFunction(10,30);