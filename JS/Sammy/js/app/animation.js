define(["lib/jquery","lib/spin","lib/jquery.spin"],function(jquery,Spinner){

	var opts = {
	  lines: 3, // The number of lines to draw
	  length: 0, // The length of each line
	  width: 25, // The line thickness
	  radius: 23, // The radius of the inner circle
	  corners: 1, // Corner roundness (0..1)
	  rotate: 57, // The rotation offset
	  direction: 1, // 1: clockwise, -1: counterclockwise
	  color: '#000', // #rgb or #rrggbb
	  speed: 0.5, // Rounds per second
	  trail: 50, // Afterglow percentage
	  shadow: false, // Whether to render a shadow
	  hwaccel: false, // Whether to use hardware acceleration
	  className: 'spinner', // The CSS class to assign to the spinner
	  zIndex: 2e9, // The z-index (defaults to 2000000000)
	  top: 'auto', // Top position relative to parent in px
	  left: 'auto' // Left position relative to parent in px
	};

	// var target = document.getElementById('animation');
	// var spinner = new Spinner(opts).spin(target);

	// $("#animation").spin(opts);
	// $("#animation").spin(false).spin(opts);

	var options = function(option){
		if(option){
			console.log("show now");
			$("#animation").spin(opts);
		}
		else{
			console.log("hide now");
			$("#animation").spin(false)
		}
	}

	return {
		options:options
	}


});