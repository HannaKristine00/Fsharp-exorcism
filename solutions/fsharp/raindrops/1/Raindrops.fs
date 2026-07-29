module Raindrops

let convert (number: int): string = 
    let nums = Map [ (3, "Pling"); (5, "Plang"); (7, "Plong")]
    let pred k v : bool =
        number % k = 0
        
    let result (col: string seq)  : string =  
        if Seq.isEmpty col then
            string number
        else
            System.String.Concat(col)
    nums 
    |> Map.filter pred
    |> Map.values
    |> result 