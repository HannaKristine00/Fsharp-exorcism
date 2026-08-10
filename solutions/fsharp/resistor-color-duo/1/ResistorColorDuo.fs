module ResistorColorDuo


let matchC (color: string) : int = 
    match color with
    | "black" -> 0
    | "brown" -> 1
    | "red" -> 2
    | "orange" -> 3
    | "yellow" -> 4
    | "green" -> 5
    | "blue" -> 6
    | "violet" -> 7
    | "grey" -> 8
    | "white" -> 9
    | _ -> failwith "no"
    
let value colors =
    match colors with
    | first :: second :: _ -> (matchC first) * 10 + (matchC second)
    | _ -> 0
    