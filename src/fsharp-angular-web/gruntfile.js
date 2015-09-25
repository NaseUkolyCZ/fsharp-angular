/// <binding BeforeBuild='uglify:my_target, copy:main' ProjectOpened='bower:install' />
module.exports = function (grunt) {
    // load Grunt plugins from NPM
    grunt.loadNpmTasks('grunt-contrib-uglify');
    grunt.loadNpmTasks('grunt-contrib-watch');
    grunt.loadNpmTasks('grunt-contrib-copy');
    grunt.loadNpmTasks('grunt-bower-task');

    // configure plugins
    grunt.initConfig({

        bower: {
            install: {
                // just run 'grunt bower:install' and you'll see files from your
                // Bower packages in lib directory
            }
        },

        uglify: {
            my_target: {
                files: {
                    'wwwroot/app.js': [
                        'lib/jquery/jquery.js',
                        'lib/**/*.js',
                        'Scripts/app.js',
                        'Scripts/**/*.js'
                    ]
                },
                options: {
                    beautify: true,
                    mangle: false
                }
            }
        },

        copy: {
            main: {
                src: 'index.html',
                dest: 'wwwroot/index.html',
            },
        },

        watch: {
            scripts: {
                files: ['Scripts/**/*.js'],
                tasks: ['uglify']
            }
        }
    });

    // define tasks
    grunt.registerTask('default', [
        'bower',
        'uglify',
        'copy',
        'watch'
    ]);
};
