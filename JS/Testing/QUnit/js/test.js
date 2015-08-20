// module("Module A");

// test("hello test",function(){
// 	ok(1=="1","Passed");
// 	equal(1,1,"1 equals 1");
// 	deepEqual([2,2],[2,2],"passed");
// });

// function isEven(val){
// 	return val % 2 == 0;
// };

// module("Module B");

// test('isEven()',function(){
// 	ok(isEven(0),"zero is even number");
// 	ok(!isEven(3),"three is not even number");
// 	// ok(isEven(1),"one is not an even number");
// });

// async test

// test('async test',function(){
	
// 	stop();

// 	setTimeout(function(){
// 		ok(true);
// 		start();
// 	},100)
// });

// asyncTest('async test 2',function(){
// 	setTimeout(function(){
// 		ok(true);
// 		start();
// 	},100)
// });

function ajax(successCallback){
	$.ajax({
		url:'path',
		success:successCallback
	});
}

test('async ajax test',function(){
	stop(100);

	ajax(function(){
		// start();
	})

	setTimeout(function(){
		start();
	},2000);
})