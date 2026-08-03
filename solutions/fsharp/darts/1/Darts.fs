module Darts

let score (x: double) (y: double): int =
    let distance = sqrt (abs x ** 2.0 + abs y ** 2.0)
    match distance with
    | inner when distance <= 1 -> 10
    | outer when distance <= 5 -> 5
    | outside when distance <= 10 -> 1
    | _ -> 0

            