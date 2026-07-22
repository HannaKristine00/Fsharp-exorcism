module Bob

let response (input: string): string = 
    let trimmed = input.Trim()
    
    match input with
    | ignored when System.String.IsNullOrWhiteSpace(trimmed) ||  System.String.IsNullOrEmpty(trimmed)-> "Fine. Be that way!"
    | angry when trimmed.EndsWith("?") && (Seq.exists System.Char.IsLower trimmed = false) && (Seq.exists System.Char.IsUpper trimmed = true)-> "Calm down, I know what I'm doing!"
    | caps when Seq.exists System.Char.IsLower trimmed = false &&  Seq.exists System.Char.IsUpper trimmed = true -> "Whoa, chill out!"
    | question when trimmed.EndsWith("?") -> "Sure."
    | _ -> "Whatever."

