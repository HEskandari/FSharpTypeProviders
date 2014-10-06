module AboutSqlTypeProvider

open FSharp.Data.Sql

type private sql = SqlDataProvider<"Server=.;Initial Catalog=AdventureWorks2008R2;Trusted_Connection=True;">


let print = 
    let context = sql.GetDataContext()
    context.``[Person].[Person]``
        |> Seq.iter(fun p -> printfn "%s, %s" p.LastName p.FirstName)
                    


















//
//let printBlueProductTransactions =
//    let context = sql.GetDataContext()
//    let query = query { for t in context.``[Production].[TransactionHistory]`` do
//                        for tp in t.FK_TransactionHistory_Product_ProductID do
//                        join p in context.``[Production].[Product]`` on (tp.ProductID = t.ProductID)
//                        where (p.Color = "Blue")
//                        select (p.Name, t.Quantity) 
//                        take 10
//                    }
//    query |> Seq.toList
//          |> Seq.iter(fun r -> printfn "%s %i" (fst r) (snd r)) 
//
//
       