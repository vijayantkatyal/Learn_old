var Utils;
(function (Utils) {
    var Formatter = (function () {
        function Formatter() { }
        Formatter.prototype.displayText = function (message) {
            console.log("########");
            console.log(message);
            console.log("########");
        };
        return Formatter;
    })();
    Utils.Formatter = Formatter;    
})(Utils || (Utils = {}));
var utils = new Utils.Formatter();
utils.displayText("Hello");
