// // BDD Interface

var assert = require("assert");

describe("Array",function(){
	before(function(){
		// console.log('started');
	});

	describe("#indexOf()",function(){
		it('should return -1 when value is not present',function(){
			assert.equal(-1,[1,2,3].indexOf(5));
			assert.equal(-1,[1,2,3].indexOf(0));
		})
	})
})

// using chai

var chai = require("chai");
chai.should();

// sync code

describe("Array",function(){
	describe("#indexOf()",function(){
		it('should return -1 when value is not present',function(){
			[1,2,3].indexOf(5).should.equal(-1);
			[1,2,3].indexOf(0).should.equal(-1);
		})
	})
})

// async code

describe('Testing Async code',function(){
	it('should take less than 500ms',function(done){
		this.timeout(500);
		setTimeout(done,300);
	})
})

// // async code

// // describe('User',function(){
// // 	describe('#save',function(){
// // 		it('should save without error',function(done){
// // 			var user = new User('Luna');
			
// // 			// user.save(function(err){
// // 			// 	if(err) throw err;
// // 			// 	done();
// // 			// });

// // 			user.save(done);
// // 		})
// // 	})
// // })

// // pending tests

// describe('Array',function(){
// 	describe('#indexOf()',function(){
// 		it('should return -1');
// 	})
// });

// // exclusive tests

// describe('Array',function(){
// 	// only runt this
// 	describe.only('#indexOf',function(){
		
// 		it.only('should run',function(){

// 		});

// 		it('should',function(){

// 		});
// 	});

// 	describe('sss',function(){
// 		it('ss',function(){

// 		})
// 	})
// })

// // inclusive tests

// describe('Array',function(){
// 	// only runt this
// 	describe.skip('#indexOf',function(){
		
// 		it('should run',function(){

// 		});

// 		it.skip('should',function(){
			
// 		});
// 	});

// 	describe('sss',function(){
// 		it('ss',function(){

// 		})
// 	})
// })

// // TDD Interface

// suite("Array",function(){
// 	setup(function(){

// 	});

// 	suite('#indexOf',function(){
// 		test('should return -1',function(){
// 			assert.equal(-1,[1,2,3]).indexOf(4);
// 		});
// 	});
// });