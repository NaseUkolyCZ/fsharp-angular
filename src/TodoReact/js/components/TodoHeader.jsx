'use strict';

var React = require('react');

module.exports = React.createClass({
    displayName: 'TodoHeader',
    render: function () {
        return (<span className="todo-count">{this.props.remaining} of {this.props.count} remaining</span>)
    }
});
