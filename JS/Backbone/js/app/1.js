(function($){
	
	Backbone.sync = function(method,model,success,error){
		success();
	}

	// Model
	var Item = Backbone.Model.extend({
		defaults:{
			part1:'hello',
			part2:'part'
		}
	});

	// Collection
	var List = Backbone.Collection.extend({
		model:Item
	});

	var ItemView = Backbone.View.extend({
		tagName:'li',

		events:{
			'click span.swap':'swap',
			'click span.delete':'remove'
		},

		initialize:function(){
			_.bindAll(this,'render','unrender','swap','remove');
			this.model.bind('change',this.render);
			this.model.bind('remove',this.unrender);
		},
		render:function(){
			$(this.el).html('<span>' + this.model.get('part1') +' '+ this.model.get('part2') +'</span>&nbsp;&nbsp;<span class="swap">[swap]</span><span class="delete">[delete]</span>');
			return this;
		},

		unrender:function(){
			$(this.el).remove();
		},

		swap:function(){
			var swapped = {
				part1: this.model.get('part2'),
				part2: this.model.get('part1')
			};
			this.model.set(swapped);
		},

		remove: function(){
			this.model.destroy();
		}
	});

	// View
	var ListView = Backbone.View.extend({
		el:$('body'),

		// events for DOM
		events:{
			'click button#add':'addItem'
		},
		
		// called upon instantiation
		initialize:function(){
			_.bindAll(this,'render','addItem','appendItem');


			// Initialize Collection
			this.collection = new List();

			// collection event binder
			this.collection.bind('add',this.appendItem);

			this.counter = 0;
			this.render();
		},

		// rendering the view
		// can be also manual or template
		render:function(){
			var self = this;
			$(this.el).append("Hello world!!");
			$(this.el).append("<br><br><button id='add'>Add new item</button>")
			$(this.el).append("<ul></ul>");


			// incase collection is not empty
			_(this.collection.models).each(function(item){
				self.appendItem(item);
			},this);
		},

		// an event
		addItem: function(){
			this.counter++;
			
			// Initialize new Item
			var item = new Item();

			// Modify Item
			item.set({
				part2: item.get('part2') + this.counter
			});

			this.collection.add(item);

			// $('ul',this.el).append("<li>hello " + this.counter + "</li>");
		},

		appendItem: function(item){
			var itemview = new ItemView({
				model: item
			});

			$('ul',this.el).append(itemview.render().el);
			// $('ul',this.el).append("<li>"+ item.get('part1') + " " + item.get('part2') +"</li>");
		}
	});

	// create new instance
	var listview = new ListView();
})(jQuery);