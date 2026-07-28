module Seq

let keep pred xs = 
    let xsList = xs |> Seq.toList
    let rec check acc list = 
        match list with
        | head :: tail -> 
            if pred head then
                check (acc @ [head]) tail
            else 
                check (acc) tail
        | [] -> acc

    check [] xsList

let discard pred xs = 
    let xsList = xs |> Seq.toList
    let rec check acc list = 
        match list with
        | head :: tail -> 
            if pred head then
                check (acc) tail 
            else 
                check (acc @  [head]) tail
        | [] -> acc

    check [] xsList