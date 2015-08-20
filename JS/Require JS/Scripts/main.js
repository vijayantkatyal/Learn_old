require.config({
  paths: {
      jquery:'lib/jquery-1.7.2' // global name alias, just edit name here once !
    // bootstrap: 'lib/bootstrap.min',
    // doT: 'lib/doT.min',
    // views: 'templates/templates',
    // datasource: 'data/json-datasource'
  }//,
  //shim: {
  //  'bootstrap': ['jquery'] // load jquery before bootstrap
  //}
});

require(["helper/util", "jquery"], function(util) {
    $(function() {
        $('body').append("jquery here");
    });
});

require(["helper/upper"], function(upper) {
    alert(upper("hello"));
});