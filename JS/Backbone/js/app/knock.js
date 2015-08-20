var Contacts = function(){
	var self = this;

	self.items = ko.observableArray(["1","2","3"]);
	self.save = function(){
		self.items.push("aa");
	}
}

ko.applyBindings(new Contacts());