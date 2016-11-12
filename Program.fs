// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open System.Diagnostics
open Problem2

[<EntryPoint>]
let main argv = 
      
    let firstArg = Array.head (match argv with [||] -> [|"10"|] | _ -> argv)
    let limit = Int32.Parse firstArg    

    let limit = 4*1000*1000

    let solution = solution2 limit

    Debug.WriteLine (sprintf "%i" solution) 
    
    printfn "%i" solution          

    

    //Return success code of 0
    0
