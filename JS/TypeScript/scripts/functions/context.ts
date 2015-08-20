declare var $;

var messageRepeater = {
	message: "<p>Hello World</p>",
	displayMessage: function(){
		$("body").append(this.message);
	},
	
	// will work
	start:function(){
		setInterval(()=> this.displayMessage(),1000);
	},

	// not work
	startJS: function(){
		setInterval(
			function(){
				this.displayMessage()
			},1000);
	}
};