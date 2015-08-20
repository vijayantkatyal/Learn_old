define(["require", "exports"], function(require, exports) {
    function displayMessage(s) {
        console.log(s);
    }
    exports.displayMessage = displayMessage;
    var example = (function () {
        function example() { }
        example.prototype.displayText = function (s) {
            console.log('######');
            console.log(s);
            console.log('######');
        };
        return example;
    })();
    exports.example = example;    
})
