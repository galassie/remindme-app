module Routing

open Giraffe

open Handlers

let routes: HttpFunc -> HttpFunc =
    choose [
        GET >=>
            choose [
                route "/" >=> text "Hello, this is RemindMe!"
                route "/api/remind" >=> handleGetReminds
            ]
        setStatusCode 404 >=> text "Not Found"
    ]

