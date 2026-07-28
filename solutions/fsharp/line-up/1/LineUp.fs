module LineUp

let format (name: string) (number: int): string = 
    match number with
    | first when number % 10 = 1 && number % 100 <> 11  -> $"{name}, you are the {number}st customer we serve today. Thank you!"
    | second when number % 10 = 2 && number % 100 <> 12 -> $"{name}, you are the {number}nd customer we serve today. Thank you!"
    | third when number % 10 = 3 && number % 100 <> 13 -> $"{name}, you are the {number}rd customer we serve today. Thank you!"
    | _ -> $"{name}, you are the {number}th customer we serve today. Thank you!"