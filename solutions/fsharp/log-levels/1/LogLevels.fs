module LogLevels

let message (logLine: string): string =
    let split = logLine.Split(':')
    let line = split[1]
    let trim = line.Trim()

    trim
    
let logLevel(logLine: string): string =
    let split = logLine.Split('[', System.StringSplitOptions.RemoveEmptyEntries)
    let split' = split[0].Split(']', System.StringSplitOptions.RemoveEmptyEntries)
    let line = split'[0]
    let lower = line.ToLower()

    lower

let reformat(logLine: string): string = 
    let line = message logLine
    let level = logLevel logLine
    let sentence = sprintf "%s (%s)" line level
    
    sentence