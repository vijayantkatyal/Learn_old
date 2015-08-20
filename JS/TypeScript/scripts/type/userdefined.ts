// using interface
// interface

interface ITaxcalculator {
	getTax(purchase: number): number;
}

// class implements interface

class DefaultTaxCalculator implements ITaxcalculator{
	getTax(purchase: number): number{
		return purchase * 0.1;
	}
}


function displayTotal(purchase: number,taxCalculator: ITaxcalculator){
	console.log("Total Value is "
		+ (purchase + taxCalculator.getTax(purchase)).toString());
}

var taxCalculator = new DefaultTaxCalculator();
displayTotal(100,taxCalculator);


// using object literal

function displayTotal2(purchase: number,taxCalculator){
	console.log("Value is "
		+ (purchase + taxCalculator.getTax(purchase)).toString());
}

displayTotal2(100,{
	getTax: function(purchase: number){
		return purchase * 0.15;
	}
});