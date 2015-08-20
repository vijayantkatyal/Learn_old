module.exports = function(grunt){
	grunt.initConfig({
		concat: {
		    options: {
		      separator: ';'
		    },
		    dist: {
		      src: ['src/intro.js', 'src/project.js'],
		      dest: 'dist/built.js'
		    }
		  }

	});

	grunt.registerTask('default','concat');

	grunt.loadNpmTasks('grunt-contrib-concat');

};