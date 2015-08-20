var spritesheetjs = require('spritesheetjs');

// Using a directory as a source
var sheet = new spritesheetjs({
    source_dir: "src",
    rel_sprite_path: "", // in case your css file and sprite image are in different directories
    sprite_path: 'dist/sprite.png',
    css_path: 'dist/sprite.css',
    selector: '.sprite'
});

// OR an array of file paths

// var sheet = new spritesheetjs({
//     images: ['path/1.jpg', 'path/2.jpg'],
//     rel_sprite_path: "", // in case your css file and sprite image are in different directories
//     sprite_path: 'out/sprite.png',
//     css_path: 'out/sprite.css',
//     selector: '.sprite'
// });

sheet.spritesheet(function(css){
    // css is an array of elements
    // {
    //  name: image/element name
    //  width,
    //  height,
    //  x,
    //  y
    // }
});
