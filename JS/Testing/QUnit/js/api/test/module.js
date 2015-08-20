module("group a",{
	setup: function(){
		// prepare something for all following tests
		console.log("load something");
	},
	teardown: function(){
		// clean up after tests
		console.log("delete somethng");
	}
});
test("a basic test example",function(){
	ok(true,"this test is fine");
});
test("a basic test example 2",function(){
	ok(true,"this is fine");
});

module("group b");
test("a basic test example 3",function(){
	ok(true,"this test is fine");
});
test("a basic test example 4",function(){
	ok(true,"this is fine");
});