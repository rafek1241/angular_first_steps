/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var merge = require('merge-stream'); 

gulp.task("scripts", function () {
 
  var streams = [];
 
  for (var prop in deps) {
    console.log("Prepping Scripts for: " + prop);
    for (var itemProp in deps[prop]) {
      streams.push(gulp.src("node_modules/" + prop + "/" + itemProp)
        .pipe(gulp.dest("src/assets/" + prop + "/" + deps[prop][itemProp])));
    }
  }
 
  return merge(streams);
 
});

var deps = {
  "jquery": {
    "dist/*": ""
  },
  "bootstrap": {
    "dist/**/*": ""
  }
};

