require.config({
    "packages": ["package1", "package2", "lib/package3",
    {
        name: 'Package4',
        location: 'package4/lib',
        main: 'main'
    }]
});

require(["package1/tool","package2","lib/package3","Package4"],function(package1,package2,package3,Package4){
    
});

//var callnow = function(){ require(["package1/tool","package2","lib/package3","Package4"],function(package1,package2,package3,Package4){
//    
//});
//}

//callnow();