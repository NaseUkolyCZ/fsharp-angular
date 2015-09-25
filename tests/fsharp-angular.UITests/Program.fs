open canopy
open runner
open System

canopy.configuration.phantomJSDir <- @"..\..\..\..\packages\PhantomJS\tools\phantomjs"

let testUrl  = "http://localhost:5000/"
let waitSecs = 3

start firefox

"todo controller calculates remaining tasks" &&& fun _ ->
    url testUrl
    sleep waitSecs
    ".todo-count" == "2 of 2 remaining"

"todo controller loads two default tasks" &&& fun _ ->
    url testUrl
    sleep waitSecs
    count ".todo-item" 2

"todo controller adds a new task" &&& fun _ ->
    url testUrl
    sleep waitSecs
    ".todo-new-title" << "test using Canopy"
    click "input[type=submit]"
    sleep waitSecs

    ".todo-count" == "3 of 3 remaining"
    count ".todo-item" 3
    ".todo-item:nth-of-type(3)" == "test using Canopy"

run()

quit()
