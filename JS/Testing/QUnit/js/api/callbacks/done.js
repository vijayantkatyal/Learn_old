QUnit.done(function(details){
	console.log("Total: " + details.total, "Failed: ",details.failed,"Passwd: ",details.passed," Runtime: ",details.runtime);
});