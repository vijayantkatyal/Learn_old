module("module a ");

QUnit.moduleStart(function(details){
	console.log("Now running: "+ details.module);
});

QUnit.moduleDone(function(details){
	console.log("Finished running: ",details.name,"Failed/total: "+ details.failed,details.total);
});