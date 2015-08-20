require.config({
    "packages": [
	    {
	        name: 'package1',
	        location: 'package1/lib',
	        main: 'convert'
	    }
    ]
});

require(["package1"],function(package1){
    
});