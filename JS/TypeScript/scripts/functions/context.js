var messageRepeater = {
    message: "<p>Hello World</p>",
    displayMessage: function () {
        $("body").append(this.message);
    },
    start: function () {
        var _this = this;
        setInterval(function () {
            return _this.displayMessage();
        }, 1000);
    },
    startJS: function () {
        setInterval(function () {
            this.displayMessage();
        }, 1000);
    }
};
