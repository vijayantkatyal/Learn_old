var DefaultTaxCalculator = (function () {
    function DefaultTaxCalculator() { }
    DefaultTaxCalculator.prototype.getTax = function (purchase) {
        return purchase * 0.1;
    };
    return DefaultTaxCalculator;
})();
function displayTotal(purchase, taxCalculator) {
    console.log("Total Value is " + (purchase + taxCalculator.getTax(purchase)).toString());
}
var taxCalculator = new DefaultTaxCalculator();
displayTotal(100, taxCalculator);
function displayTotal2(purchase, taxCalculator) {
    console.log("Value is " + (purchase + taxCalculator.getTax(purchase)).toString());
}
displayTotal2(100, {
    getTax: function (purchase) {
        return purchase * 0.15;
    }
});
