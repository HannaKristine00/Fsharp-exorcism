module Accumulate

let accumulate (func: 'a -> 'b) (input: 'a list): 'b list = 
    let rec loop acc list =
        match list with
        | head :: tail -> loop (func head :: acc) tail
        | [] -> acc

    loop [] input |> List.rev

    