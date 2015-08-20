asyncTest("async Test: one Second Later",function(){
	expect(1);

	setTimeout(function(){
		ok(true,"Passed and Ready to Resume");
		start();
	},1000);
});

// asyncTest("async test: video ready to play",1,function(){
// 	var $video = $("video");

// 	$video.on("canplaythrough",function(){
// 		ok(true,"video has loaded and is ready to play");
// 		start();
// 	});
// });