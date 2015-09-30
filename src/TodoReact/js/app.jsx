'use strict';

var React = require('react');
var TodoView = require('./components/TodoView');

var url = 'http://localhost:5042/';

fetch(url + 'api/todo')
    .then(function (response) { return response.json() })
    .then(function (todos) {
        React.render(
          <TodoView todos={todos } />,
            document.getElementById('todo-view')
        );
    })
    .catch(function (ex) {
        console.log('parsing failed', ex)
    });
