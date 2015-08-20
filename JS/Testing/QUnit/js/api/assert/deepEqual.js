// used for comparing objects.

test("deepEqual Test",function(){
	var obj = { foo:"bar" };

	deepEqual(obj,{foo:"bar"},"Two Objects can be the same in value");
})