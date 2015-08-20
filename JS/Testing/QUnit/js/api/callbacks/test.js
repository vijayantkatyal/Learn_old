module("A");
test("aa",function(){
	ok(true,"asda");
});

QUnit.testStart(function(details){
	console.log("now running:" + details.module);
})

QUnit.testDone(function(details){
	console.log("Finished running: ", details.module, details.name,"Failed/Total: ",details.failed,details.total);
})