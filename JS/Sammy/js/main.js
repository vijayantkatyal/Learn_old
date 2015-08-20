require.config({
	shim:{
		'lib/sammy':['lib/jquery']
	}
});

require(["app/routes","app/hash"],function(){

});