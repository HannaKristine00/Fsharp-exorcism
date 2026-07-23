module TwoFer

let twoFer (input: string option): string = 
    match input with
    | Some input -> $"One for %s{input}, one for me."
    | None -> "One for you, one for me."