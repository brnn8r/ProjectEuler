module Fibonacci
    let rec fibs = seq {
        yield 0
        yield 1
        yield! Seq.map2 (+) fibs (fibs |> Seq.skip 1)
    }
        

