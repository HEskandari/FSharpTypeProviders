module AboutWorldBankTypeProvider

open FSharp.Data    
open FSharp.Charting

let private getData (countryName : string) =
    let wb = WorldBankData.GetDataContext()
    let country = wb.Countries |> Seq.find (fun x -> x.Name.Equals countryName)
    country.Indicators.``School enrollment, preprimary (% gross)``





let print country = 
    let indicator = getData country |> Seq.maxBy fst
    printfn "Year: %A Value %A" (fst indicator) (snd indicator)
    
    
    
    
        
let chart country =
    let graph = getData country |> Chart.Line
    graph.ShowChart
    




let countriesChart = 
    let wb = WorldBankData.GetDataContext()
    let countries = [| 
                        wb.Countries.Argentina
                        wb.Countries.Australia
                        wb.Countries.Canada
                        wb.Countries.China
                        wb.Countries.France
                        wb.Countries.Germany
                        wb.Countries.``United Kingdom``
                        wb.Countries.``United States`` 
                    |]
    let chart = [for c in countries -> c.Indicators.``School enrollment, preprimary (% gross)``]
                    |> Seq.map Chart.Line
                    |> Chart.Combine
    chart.ShowChart
        




type WorldBankAsync = WorldBankDataProvider<"World Development Indicators", Asynchronous = true>

let countriesChartAsync = 
    let wb = WorldBankAsync.GetDataContext()
    let countries = [| 
                        wb.Countries.Argentina
                        wb.Countries.Australia
                        wb.Countries.Canada
                        wb.Countries.China
                        wb.Countries.France
                        wb.Countries.Germany
                        wb.Countries.``United Kingdom``
                        wb.Countries.``United States`` 
                    |]
    let chart = [for c in countries -> c.Indicators.``School enrollment, preprimary (% gross)``]
                    |> Async.Parallel
                    |> Async.RunSynchronously
                    |> Seq.map Chart.Line
                    |> Chart.Combine
    chart.ShowChart
        

