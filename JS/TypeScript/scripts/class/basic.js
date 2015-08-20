var Car = (function () {
    function Car(horsePower, make, model) {
        this.horsePower = horsePower;
        this.make = make;
        this.model = model;
        console.log("Car1 has been created");
    }
    Car.prototype.getHorsePower = function () {
        return this.horsePower;
    };
    Car.prototype.getMake = function () {
        return this.make;
    };
    Car.prototype.getModel = function () {
        return this.model;
    };
    return Car;
})();
var car1 = new Car(100, "Honda", "800");
console.log(car1.getHorsePower());
console.log(car1.getMake());
console.log(car1.getModel());
