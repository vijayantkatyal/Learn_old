// log change in target value

ko.extenders.logChange = function(target,option){
	target.subscribe(function(newValue){
		console.log(option + ": " + newValue);
	});
	return target;
};

// forcing input to be numeric

ko.extenders.numeric = function(target,percision){

	var result = ko.computed({
		read: target,
		write: function(newValue){
			var current = target(),
			roundingMultiplier = Math.pow(10,percision),
			newValueAsNum = isNaN(newValue) ? 0:parseFloat(+newValue),
			valueToWrite = Math.round(newValueAsNum * roundingMultiplier) / roundingMultiplier;

			if(valueToWrite !== current){
				target(valueToWrite);
			}else{
				if(newValue !== current){
					target.notifySubscribers(valueToWrite);
				}
			}
		}
	});
	
	result(target());

	return result;
};

ko.extenders.hello = function(target,message){
	
	var result = ko.computed({
		read:target,
		write:function(newValue){
			var current = target(),
			valueToWrite = message;

			target(valueToWrite);
			target.notifySubscribers(valueToWrite);
		}
	});

	result(target());

	return result;
};

ko.extenders.required = function(target,overrideMessage){

	target.hasError = ko.observable();
	target.validationMessage = ko.observable();

	function validate(newValue){
		target.hasError(newValue ? false:true);
		target.validationMessage(newValue ? "":overrideMessage || "this field is required");
	}

	validate(target());
	target.subscribe(validate);
	return target;
};

var model = {
	name: ko.observable('hello vijayant').extend({
		logChange: "name"
	}),
	number:ko.observable('221.2234').extend({
		numeric: 2
	}),
	description: ko.observable('description here').extend({
		hello: 'default'
	}),
	age: ko.observable('21').extend({
		required: "please enter age !"
	})
};

ko.applyBindings(model);