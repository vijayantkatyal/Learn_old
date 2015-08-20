///<reference path="knockout.d.ts" />
///<amd-dependency path="../lib/knockout" />

// declare var ko;

export function example(){
	var self = this;
	self.name =  ko.observable('name here');
}