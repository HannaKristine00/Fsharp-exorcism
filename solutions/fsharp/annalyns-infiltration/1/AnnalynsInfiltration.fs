module AnnalynsInfiltration

let canFastAttack (knightIsAwake: bool): bool = 
    // not knightIsAwake
    if knightIsAwake then false
    else true
    
let canSpy (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    if knightIsAwake || archerIsAwake || prisonerIsAwake then true
    else false

let canSignalPrisoner (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    if prisonerIsAwake && not archerIsAwake then true
    else false

let canFreePrisoner (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool): bool =
    if petDogIsPresent  && not archerIsAwake then true
    else if prisonerIsAwake && not archerIsAwake && not knightIsAwake then true else false

