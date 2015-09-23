open canopy
open runner
open System

start firefox

"simple angular controller is working" &&& fun _ ->

    //go to url
    url "http://localhost:5523/"

    "#food" == "pizza"

    "#sentence" == "Sriracha sauce is great with pizza!"

    "#food" << "eggs"

    "#sentence" == "Sriracha sauce is great with eggs!"

run()

quit()
