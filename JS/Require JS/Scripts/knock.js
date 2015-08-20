require.config({
    paths: {
        knockout: 'lib/knockout-2.1.0' ,// global name alias, just edit name here once !
        jquery: 'lib/jquery-1.7.2',
        templ_engine:'lib/koExternalTemplateEngine_all',
        templ_confg:'lib/tmpl.confg'
    },
    shim: {
        'knockout': ['jquery'], // load jquery before bootstrap
        'helper/MyViewModel':['knockout'],
        'templ_engine':['knockout'],
        'templ_confg':['templ_engine']
    }
});


require(['knockout','helper/MyViewModel','templ_engine','templ_confg'], function(ko, MyViewModel) {
    ko.applyBindings(new MyViewModel());
});