module AboutJsonTypeProvider

open FSharp.Data

type private P = JsonProvider<"""{ "first_name": "", "last_name": "", "email":"" }""">

let print =

    let person = P.Parse(""" { "first_name": "Scarlet", "last_name": "Cartan", "email":"scarlet.cartan@yahoo.com" } """)
    printfn "Name: %A %A Email: %A" person.FirstName person.LastName person.Email

