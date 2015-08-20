(function($){
	
	$.fn.myPlugin = function(options){
		
		// return this.each(function(){
		// 	// $(this).hide();
		// 	// $(this).text("hello, world!");
		// 	// $(this).fadeIn('slow');
		// });
		
		// return this.each(function(){
		// 	$(this).text(customText);
		// });

		var settings = $.extend({
			text      : 'hello, world!',
			color     : null,
			fontStyle : null,
			complete  : null
		},options);

		return this.each(function(){
			$(this).hide();

			$(this).text(settings.text);
			
			if(settings.color){
				$(this).css('color',settings.color);
			}

			if(settings.fontStyle){
				$(this).css('font-style',settings.fontStyle);
			}

			if($.isFunction(settings.complete)){
				settings.complete.call(this);
			}

			$(this).fadeIn('slow');
		});

	};

})(jQuery);