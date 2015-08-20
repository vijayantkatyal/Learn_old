test("expect test",function(){
	expect(2);

	function calc(x,operation){
		return operation(x);
	}

	var result = calc(2,function(x){
		ok(true,"cal calls operation function");
		return x*x;
	});

	equal(result,4,"2 square equals 4");

});