define(["require", "exports"], function(require, exports) {
    var Model1 = (function () {
        function Model1() { }
        Model1.prototype.displayMessage = function (s) {
            return console.log("hello form: " + s);
        };
        Model1.prototype.displayMessage2 = function (s) {
            return console.log("hello " + s);
        };
        return Model1;
    })();
    exports.Model1 = Model1;    
})
