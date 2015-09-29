(function () {
    'use strict';

    angular.module('app', [])
        .value('todoServiceUrl', 'http://localhost:5042/')
        .controller('TodoListController', [
        '$scope', '$http', '$log', 'todoServiceUrl',
        function ($scope, $http, $log, todoServiceUrl) {

            var todoList = this;

            todoList.todos = [];

            todoList.addTodo = function () {
                var todo = { title: todoList.todoText };

                todoList.todoText = '';

                $log.info('Posting todo item: ' + todo.title);

                $http.post(todoServiceUrl + 'api/todo', todo).then(function (data) {
                    $log.info('Got todo item back: ' + data.data.title);
                    todoList.todos.push(data.data);
                })
            };

            todoList.remaining = function () {
                var count = 0;
                angular.forEach(todoList.todos, function (todo) {
                    count += todo.completed ? 0 : 1;
                });
                return count;
            };

            todoList.archive = function () {
                var oldTodos = todoList.todos;
                todoList.todos = [];
                angular.forEach(oldTodos, function (todo) {
                    if (!todo.completed) todoList.todos.push(todo);
                });
            };

            $log.info('Fetching todo items.');

            $http.get(todoServiceUrl + 'api/todo').success(function (data) {
                $log.info('Got ' + data.length + ' todo items.');
                todoList.todos = data;
            });
        }
    ]);
})();