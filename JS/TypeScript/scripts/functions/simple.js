function addTwoNumbers(number1, number2) {
    console.log(number1 + number2);
    return number1 + number2;
}
var add = function (n1, n2) {
    console.log(n1 + n2);
    return n1 + n2;
};
var addAndLogicFunction;
addAndLogicFunction = addTwoNumbers;
addAndLogicFunction(10, 32);
addAndLogicFunction = add;
addAndLogicFunction(10, 30);
