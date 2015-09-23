/// <binding BeforeBuild='bower, default' />
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
                options: {
                    mangle: false,
                    beautify: true
                },
                files: {
                    'wwwroot/app.js': [
                        'lib/jquery/jquery.js',
                        'lib/**/*.js',
                        'Scripts/app.js',
                        'Scripts/**/*.js'
                    ]
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
        'copy'
    ]);
};
