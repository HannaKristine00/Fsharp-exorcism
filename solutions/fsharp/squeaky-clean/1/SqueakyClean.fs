module SqueakyClean

open System

let transform (c: char) : string =
    match c with
        | '-' -> "_"
        | w when Char.IsWhiteSpace w -> ""
        | k when Char.IsUpper k -> "-" + string (Char.ToLower k)
        | d when Char.IsDigit d -> ""
        | g when Char.IsLower g && 'α' <= g && g <= 'ω' -> "?"
        | _ -> string c


let clean (identifier: string): string = 
    identifier
    |> String.collect transform
    