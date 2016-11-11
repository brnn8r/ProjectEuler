module Multiples

    let multiples num limit =    
        let upperLimit = limit-1    
        List.map (fun x -> x*num) [1..upperLimit/num]
            
