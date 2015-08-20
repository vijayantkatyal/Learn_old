class Car{
	
	// private horsePower: number;
	// private make: string;
	// private model: string;

	constructor (private horsePower: number,private make: string,private model: string){
		
		// this.horsePower = horsePower;
		// this.make = make;
		// this.model = model;
		
		console.log("Car1 has been created");
	}

	getHorsePower(){
		return this.horsePower;
	}

	getMake(){
		return this.make;
	}

	getModel(){
		return this.model;
	}

}

var car1 = new Car(100,"Honda","800");
console.log(car1.getHorsePower());
console.log(car1.getMake());
console.log(car1.getModel());