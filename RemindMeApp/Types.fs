module Types

open System

[<CLIMutable>]
type Remind = 
    { Id: string 
      Title: string
      Description: string
      Date: DateTime }