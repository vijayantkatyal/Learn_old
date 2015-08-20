test("start() test",function(){
	stop();

	setTimeout(function(){
		ok(true,"someExpected Value");
		start();
	},1000);
});