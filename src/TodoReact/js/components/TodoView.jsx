'use strict';

var React = require('react');
var TodoHeader = require('./TodoHeader');
var TodoItem = require('./TodoItem');

module.exports = React.createClass({
    displayName: 'TodoView',
    render: function () {

        var remaining = 0;
        var todos = [];

        for (var i in this.props.todos) {
            remaining += this.props.todos[i].completed ? 0 : 1;
            todos.push(<TodoItem key={i} todo={this.props.todos[i] } />);
        }

        return (<div>
            <TodoHeader remaining={remaining} count={this.props.todos.length} />
            <ul>{todos}</ul>
        </div>)
    }
});
