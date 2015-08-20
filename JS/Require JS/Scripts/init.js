require.config({
    paths: {
        knockout: 'lib/knockout-2.1.0' // global name alias, just edit name here once !
    },
    shim: {
        'bootstrap': ['jquery'] // load jquery before bootstrap
    }
});

require(["knockout", 'helper/appViewModel'], function(ko, appViewModel) {
    ko.applyBindings(new appViewModel());
});