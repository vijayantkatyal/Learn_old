class Man{
	constructor(private description: string){

	}

	public getPower(){
		return 1;
	}

	getDescription(){
		return this.description;
	};
}

class Superhero extends Man{
	getPower(){
		return super.getPower()*2;
	};
}

class Batman extends Superhero {
	getPower(){
		return super.getPower()*3;
	};
}

class Superman extends Superhero{
	getPower(){
		return super.getPower()*10;
	}
}

var batman = new Batman("drives batmobile");
console.log(batman.getDescription());
console.log(batman.getPower());

var superman = new Superman("fly high");
console.log(superman.getDescription());
console.log(superman.getPower());

console.log("Batman is of type Superman");
console.log(batman instanceof Superman);