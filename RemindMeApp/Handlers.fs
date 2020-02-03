module Handlers

open System
open Microsoft.AspNetCore.Http
open Giraffe

open Types

let reminds = 
    [ { Id = "1"; Title = "First remind!"; Description = "This is the first remind created!"; Date = DateTime.UtcNow } 
      { Id = "2"; Title = "Second remind!"; Description = "Second one!"; Date = DateTime.UtcNow }
      { Id = "3"; Title = "Third remind!"; Description = "Getting addicted!"; Date = DateTime.UtcNow } ]

let handleGetReminds (next: HttpFunc) (ctx : HttpContext) =
    json reminds next ctx