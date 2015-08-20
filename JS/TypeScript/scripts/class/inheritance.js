var __extends = this.__extends || function (d, b) {
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Man = (function () {
    function Man(description) {
        this.description = description;
    }
    Man.prototype.getPower = function () {
        return 1;
    };
    Man.prototype.getDescription = function () {
        return this.description;
    };
    return Man;
})();
var Superhero = (function (_super) {
    __extends(Superhero, _super);
    function Superhero() {
        _super.apply(this, arguments);

    }
    Superhero.prototype.getPower = function () {
        return _super.prototype.getPower.call(this) * 2;
    };
    return Superhero;
})(Man);
var Batman = (function (_super) {
    __extends(Batman, _super);
    function Batman() {
        _super.apply(this, arguments);

    }
    Batman.prototype.getPower = function () {
        return _super.prototype.getPower.call(this) * 3;
    };
    return Batman;
})(Superhero);
var Superman = (function (_super) {
    __extends(Superman, _super);
    function Superman() {
        _super.apply(this, arguments);

    }
    Superman.prototype.getPower = function () {
        return _super.prototype.getPower.call(this) * 10;
    };
    return Superman;
})(Superhero);
var batman = new Batman("drives batmobile");
console.log(batman.getDescription());
console.log(batman.getPower());
var superman = new Superman("fly high");
console.log(superman.getDescription());
console.log(superman.getPower());
console.log("Batman is of type Superman");
console.log(batman instanceof Superman);
