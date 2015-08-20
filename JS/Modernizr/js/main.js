require.config({
	baseUrl:"js/",
	paths:{
		'modernizr':'lib/modernizr'
	},
	"packages":[
		{
			name:"package1",
			location:"packages/package1",
			main:"geo"
		}
	],shim:{
  		// 'package1':['lib/modernizr']
	}
});

require(["package1","test"],function(){

});