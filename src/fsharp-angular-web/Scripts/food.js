(function () {
    'use strict';

    angular
        .module('app')
        .controller('food', food);

    food.$inject = ['$location']; 

    function food($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'pizza';

        activate();

        function activate() { }
    }
})();
