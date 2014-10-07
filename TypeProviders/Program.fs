module TypeProviderExamples

open System
open System.Windows.Forms

    [<EntryPoint>]
    [<STAThread>]
    let main argv = 
        //AboutCSVTypeProviders.print() |> ignore
        //AboutJsonTypeProvider.print() |> ignore
        //AboutFreebaseTypeProvider.print() |> ignore
        //AboutSqlTypeProvider.print() |> ignore
        //AboutSqlTypeProvider.printBlueProductTransactions() |> ignore
        //AboutWorldBankTypeProvider.print "Australia" |> ignore
        //let f = AboutWorldBankTypeProvider.chart "Australia"
        //let f = AboutWorldBankTypeProvider.countriesChart
        //let f = AboutWorldBankTypeProvider.countriesChartAsync
        //Application.Run (f())
        printf "Press any key to continue..."
        System.Console.ReadKey() |> ignore
        0 // return an integer exit code
