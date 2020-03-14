// Learn more about F# at http://fsharp.org

open System
open System.Diagnostics

[<EntryPoint>]
let main argv =
    let yearToRun = if Array.length argv > 0 then argv.[0] else "2020"

    match yearToRun with
    | "2019" -> 
        let iterations = 
            if Array.length argv > 1
            then Int32.Parse(argv.[1])
            else Int32.MaxValue
        let timer = Stopwatch()
        timer.Start()
        let result = Nilakanatha.run iterations
        timer.Stop()
        printfn "(2019) Nilakanatha. Results in pi ~= %.32f" result
        printfn "\t(iterations = %d. elapsed seconds = %d)" iterations timer.Elapsed.Seconds
    | "2020" ->
        let digits = 
            if Array.length argv > 1
            then Int32.Parse(argv.[1])
            else 100000
        let timer = Stopwatch()
        timer.Start()
        let result = Chudnovsky.run digits
        timer.Stop()
        printfn "(2020) Chudnovsky. Results in pi ~= %s" <| result.ToString()
        printfn "\t(digits = %d. elapsed seconds = %s)" digits (timer.Elapsed.TotalSeconds.ToString())
    | _ -> 
        printfn "We haven't done anything for the year %s yet. Try another year?" yearToRun

    0