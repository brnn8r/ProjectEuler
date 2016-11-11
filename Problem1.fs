module Problem1

open Multiples

    let Solution limit = 
        let multiplesOf3 = multiples 3 limit
        let multiplesOf5 = multiples 5 limit
        let combinedMultiples = Set.union (Set.ofList multiplesOf3) (Set.ofList multiplesOf5) |> Set.toList

        List.sum combinedMultiples

