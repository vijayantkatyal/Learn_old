define(["require", "exports", "../lib/knockout"], function(require, exports,ko) {
    function example() {
        var self = this;
        self.name = ko.observable('name here');
    }
    exports.example = example;
})
