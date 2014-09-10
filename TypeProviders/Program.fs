open System
open System.Windows.Forms

module TypeProviderExamples =

    [<EntryPoint>]
    [<STAThread>]
    let main argv = 
        //AboutCSVTypeProviders.print
        AboutJsonTypeProvider.print
        //AboutWorldBankTypeProvider.print "Australia"
        //let f1 = AboutWorldBankTypeProvider.chart "Australia"
        //let f2 = AboutWorldBankTypeProvider.countriesChart
        //let f3 = AboutWorldBankTypeProvider.countriesChartAsync
        //Application.Run (f3())
        printf "Press any key to continue..."
        System.Console.ReadKey() |> ignore
        0 // return an integer exit code
