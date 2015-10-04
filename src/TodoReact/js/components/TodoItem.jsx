'use strict';

var React = require('react');

module.exports = React.createClass({
    displayName: 'TodoItem',
    render: function () {
        console.log(this.props.todo);
        return (
            <li className="todo-item">
                <input type="checkbox" checked={this.props.todo.completed} />
                <span>{this.props.todo.title}</span>
            </li>
        );
    }
});
