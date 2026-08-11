module Triangle

let check (triangle: float list) =
    let a, b, c = triangle[0], triangle[1], triangle[2]
    if (a + b >= c) && (b + c >= a) && (a + c >= b) && (triangle |> Seq.contains 0.0) = false then
        true
    else
        false
    
let equilateral triangle =
    if check triangle then 
        if (triangle |> Set.ofList |> Set.count) <= 1 then
            true
        else
            false
    else    
        false
    
let isosceles (triangle: float list) = 
    if check triangle then
        if (triangle |> Set.ofList |> Set.count) <= 2 then
            true
        else
            false
    else    
        false
        
let scalene (triangle: float list) = 
    if check triangle then
        if (triangle |> Set.ofList |> Set.count) = 3 then
            true
        else
            false
    else    
        false
    