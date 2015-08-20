(function($){

	Backbone.sync = function(method,model,success,error){
		success();
	};

	// Model
	var Contact = Backbone.Model.extend({
		defaults:{
			name:"new contact",
			email:"name@web.com"
		}
	});

	// Collection
	var Contacts = Backbone.Collection.extend({
		model:Contact
	});

	// View
	var ItemView = Backbone.View.extend({
		tagName:'li',
		events:{
			'click span.delete':'remove'
		},
		initialize:function(){
			_.bindAll(this,'render','unrender','remove');
			this.model.bind('remove',this.unrender);
		},
		render:function(){
			$(this.el).html('<span>' + this.model.get('name') + " - " + this.model.get('email') + '</span>&nbsp;<span class="delete">[ x ]</span>');
			return this;
		},
		unrender:function(){
			$(this.el).remove();
		},
		remove:function(){
			this.model.destroy();
		}
	})

	// View
	var ContactView =  Backbone.View.extend({
		el:$('body'),

		// events
		events:{
			'click button#add':'addContact'
		},

		initialize:function(){
			_.bindAll(this,'render','addContact','appendContact');
			this.collection = new Contacts();
			this.collection.bind('add',this.appendContact);
			this.counter = 0;
			this.render();
		},

		render:function(){
			$(this.el)
				.append("Contact Manager")
				.append("<br><br>")
				.append("<input type='text' placeholder='name' id='name'><input placeholder='email' id='email'><button id='add'>Add New</button>")
				.append("<ol></ol>");

			var self = this;
			_(this.collection.models).each(function(item){
				self.appendItem(item);
			},this);
		},

		addContact:function(){
			this.counter++;

			// var item = new Contact({name:"vijayant katyal",email:"vijayantkatyal@hotmail.com"});
			var item = new Contact({name:$("#name").val(),email:$("#email").val()});
			this.collection.add(item);
			
			//$("ol",this.el)
			//	.append("<li><b>" + item.get('name') +"</b> - " + item.get("email") + "</li>");
		},

		appendContact:function(item){
			var itemview = new ItemView({
				model:item
			});

			$("ol",this.el).append(itemview.render().el);
		}
	});

	var contactview = new ContactView();

})(jQuery);