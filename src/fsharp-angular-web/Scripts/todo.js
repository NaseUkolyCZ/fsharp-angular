(function () {
    'use strict';

    angular.module('todoApp', []).controller('TodoListController', [
        '$scope', '$http', function ($scope, $http) {

            var todoList = this;

            todoList.todos = [];

            todoList.addTodo = function () {
                var todo = {
                    title: todoList.todoText,
                    completed: false
                };

                todoList.todoText = '';

                $http.post('api/todo', todo).then(function (data) {
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

            $http.get('api/todo').success(function (data) {
                todoList.todos = data;
            });
        }
    ]);
})();