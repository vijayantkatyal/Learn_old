define(['knockout'], function(ko) {
    return function appViewModel() {
        this.firstname = ko.observable('Vijayant');
        this.firstnamecaps = ko.computed(function() {
            return this.firstname().toUpperCase();
        }, this);
    };
});