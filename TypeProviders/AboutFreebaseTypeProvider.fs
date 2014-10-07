module AboutFreebaseTypeProvider

open FSharp.Data
open FSharp.Charting

let print () = 
    let fb = FreebaseData.GetDataContext()
    let data = query { 
                    for e in fb.``Science and Technology``.Chemistry.``Chemical Elements`` do
                    where (e.``Atomic number``.HasValue = true)
                    sortBy e.``Atomic number``.Value }
    data |> Seq.toList
         |> Seq.iter(fun x -> printfn "%s %s [%i]" x.Name x.Symbol x.``Atomic number``.Value)
