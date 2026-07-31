module BinarySearch

let find input value = 
    let sorted = Array.sort input
   
    let rec loop first second =
        if first > second then
            None
        else
            let idx = (first + second) / 2
            if sorted[idx] = value then 
                Some idx
            elif sorted[idx] < value then
                loop (idx + 1) second
            else
               loop first (idx - 1)
            
    loop 0 (sorted.Length - 1)
