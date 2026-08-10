module Clock

let create hours minutes =
    let total = (hours * 60) + minutes
    let time = ((total % 1440) + 1440) % 1440
    sprintf "%02d:%02d" (time/60) (time % 60)
    
    
    
let add minutes clock = 
    let time = (clock: string).Split(":")
    let h = int time[0]
    let m = int time[1]
    create h (m + minutes)
    
let subtract minutes clock = 
    let time = add (-minutes) clock
    time
    
let display clock = 
    clock