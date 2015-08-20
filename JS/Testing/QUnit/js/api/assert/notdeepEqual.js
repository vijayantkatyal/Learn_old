test("notdeepEqual",function(){
	var obj = { foo: "abc" };

	notDeepEqual(obj,{foo:"def"},"different object, same key, different value, not equal");
});