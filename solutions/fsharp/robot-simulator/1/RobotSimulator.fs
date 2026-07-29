module RobotSimulator

type Direction = 
    | North 
    | East 
    | South 
    | West

    
type Position = int * int

let create direction position = (direction, position)
    
let move instructions robot = 

    let left direction : Direction =
        match direction with
        | North -> West
        | West -> South
        | South -> East
        | East -> North
        
    let right direction : Direction =
        match direction with
        | North -> East
        | East -> South
        | South -> West
        | West -> North

    let advance direction (x, y) : Position = 
        match direction with
        | North -> (x, y + 1)
        | East -> (x + 1, y)
        | West -> (x - 1, y)
        | South -> (x, y - 1)

    let matchCToD (direction, (x,y)) c =
        match c with
        | 'R' -> create (right direction) (x, y)
        | 'L' -> create (left direction) (x, y)
        | 'A' -> create direction (advance direction (x, y))
        | _ -> create direction (x,y)

    Seq.fold matchCToD robot instructions 
