test("throws test",function(){
	function CustomError(message){
		this.message = message;
	}

	CustomError.prototype.toString = function(){
		return this.message;
	};

	throws(
		function(){
			throw new CustomError();
		},CustomError,
		"raised error is an instance of CustomError"
	);

	throws(
		function(){
			throw new CustomError("some error description");
		},
		// description
		"raised error message containes 'description'");
});