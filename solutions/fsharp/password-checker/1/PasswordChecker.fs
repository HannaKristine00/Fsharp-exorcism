module PasswordChecker

type PasswordError =
    | LessThan12Characters
    | MissingUppercaseLetter
    | MissingLowercaseLetter
    | MissingDigit
    | MissingSymbol

/// Validate the given password against the rules defined in the instructions. If it meets all
/// of the rules, return a result indicating success; otherwise return a result indicating
/// failure and an error indicating which rule was violated.
let checkPassword (password: string) : Result<string, PasswordError> =
    let hasLength = String.length password >= 12
    let hasUpper = Seq.exists System.Char.IsUpper password
    let hasLower = Seq.exists System.Char.IsLower password
    let hasDigit = Seq.exists System.Char.IsDigit password
    let hasSymbol = password |> Seq.exists (fun c -> Seq.contains c "!@#$%^&*")

    match hasLength, hasUpper, hasLower, hasDigit, hasSymbol with
    | false, _, _, _, _ -> Error LessThan12Characters
    | _, false, _, _, _ -> Error MissingUppercaseLetter
    | _, _, false, _, _ -> Error MissingLowercaseLetter
    | _, _, _, false, _ -> Error MissingDigit
    | _, _, _, _, false -> Error MissingSymbol
    | _ -> Ok password
    
    

/// Return a human-readable message indicating the meaning of the given result value.
let getStatusMessage (result: Result<string, PasswordError>) : string =
    match result with
    | Error LessThan12Characters -> "Error: does not have at least 12 characters" 
    | Error MissingUppercaseLetter -> "Error: does not have at least one uppercase letter"
    | Error MissingLowercaseLetter -> "Error: does not have at least one lowercase letter"
    | Error MissingDigit-> "Error: does not have at least one digit"
    | Error MissingSymbol -> "Error: does not have at least one symbol"
    | _ -> "OK"