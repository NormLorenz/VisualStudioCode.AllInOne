/// <reference path="typings/gulp/gulp.d.ts"/>
var gulp = require('gulp'),
    compiler = require('./wwwroot/javascripts/ember-template-compiler.js'),
    htmlbars = require('gulp-htmlbars-compiler'),
    wrap = require('gulp-wrap'),
    declare = require('gulp-declare'),    
    concat = require('gulp-concat');

/**
 * Build all files (javascript)
 **/
 gulp.task('all', function() {
    gulp.start('app');
    gulp.start('templates');
 });
    
/**
 * Build app file (javascript)
 **/
gulp.task('app', function() {
    gulp.src(['wwwroot/app/**/*.js'])
        .pipe(concat('app.js'))
        .pipe(gulp.dest('wwwroot/build/'));
});

/**
 * Build templates file (javascript)
 **/
gulp.task('templates', function() {
    return gulp.src('wwwroot/app/templates/**/*.hbs')
        .pipe(htmlbars({
            compiler: compiler 
        }))
        .pipe(concat('templates.js'))
        .pipe(gulp.dest('wwwroot/build/'));
});

/**
 * Watch files modifications and rebuild
 **/
gulp.task('watch', function() {
    gulp.start('app');
    gulp.start('templates');

    gulp.watch('public/app/**/*', function() {
        gulp.start('app');
        gulp.start('templates');
    });
});