define(['lib/jquery','lib/sammy','app/animation'],function(jquery,Sammy,anim){


	// plugin
	var MyPlugin = function(app){
		
		this.helpers({
			alert: function(message){
				this.log("ALERT! " + message);
			}
		});

	}

	// sammy routing
	Sammy("#view",function(){ // elemnt is #view for ops

	   // implements a 'fade out'/'fade in'
	   this.swap = function(content, callback) {
		    var context = this;
		     
		    context.$element().fadeOut('fast', function() {
		    	
		    	// for displaying animation
		    	anim.options(true);
		       	
		       	context.$element().html(content);
		       	context.$element().fadeIn('slow', function() {

		       		// for stopping animation
		       		anim.options(false);
		         	
		         	if (callback) {
		           		callback.apply();
		         	}
		       });
		    });
	   };


		this.use(MyPlugin);

		this.get('home',function(){
			this.alert("i'm home");
			this.swap();
			$("#view").load('home.html');
		});

		this.get('contact',function(){
			this.alert("i'm contact");
			this.swap();
			$("#view").load('contact.html');
		});

		// route with parameter
		this.get('name/:name',function(){
			$("#view").html(this.params['name']);
			this.swap();
		});

	}).run();
})