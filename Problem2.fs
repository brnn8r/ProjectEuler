module Problem2

open Fibonacci

    let solution2 limit = 
        fibs |> Seq.filter (fun x-> x % 2 = 0) |> Seq.takeWhile (fun x-> x < limit) |> Seq.sum
