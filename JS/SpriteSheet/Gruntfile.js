module.exports = function(grunt){
	
	grunt.initConfig({
        sprite: {
            dist: {
                src: ['src/*.png'],
                destImg: 'dist/sprite.png',
                destCSS: 'dist/sprite.less',
                cssFormat: 'less',
                // imgPath: '../images/sprite.png',
                algorithm: 'left-right'
            }
        }
    });



	grunt.registerTask('default','sprite');

	grunt.loadNpmTasks('grunt-spritesmith');

};