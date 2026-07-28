module CollatzConjecture

let steps (number: int): int option = 
    let rec loop acc num =
        if num = 1 then
            acc
        elif num % 2 = 0 then
            loop (acc + 1) (num / 2)
        else
            loop (acc + 1) (num * 3 + 1)

    if number < 1 then 
        None
    else 
        Some (loop 0 number)


    