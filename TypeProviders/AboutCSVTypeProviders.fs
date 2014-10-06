module AboutCSVTypeProviders

open FSharp.Data
open System.IO

type private People = CsvProvider<"./Sample.csv">

let print =

    let data = File.OpenRead("./Sample.csv")
    let csv = People.Load data

    let people = csv.Rows
                    |> Seq.map (fun row -> row)
                    |> Seq.filter (fun row -> row.first_name.Equals "Pete")
                    |> Seq.toArray

    people 
        |> Seq.iter (fun person -> printfn "Name: %s %s Email: %s" person.first_name person.last_name person.email)

