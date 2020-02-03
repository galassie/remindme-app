module Routing

open Giraffe

open Handlers

let routes: HttpFunc -> HttpFunc =
    choose [
        GET >=>
            choose [
                route   "/"                 >=> text "Hello, this is RemindMe!"
                route   "/api/remind"       >=> handleGetReminds
                routef  "/api/remind/%s"    handleGetRemind
            ]
        RequestErrors.NOT_FOUND "Not found!"
    ]

