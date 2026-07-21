module LuciansLusciousLasagna

// TODO: define the 'expectedMinutesInOven' binding
let expectedMinutesInOven: int = 40

// TODO: define the 'remainingMinutesInOven' function
let  remainingMinutesInOven(x: int) =
    expectedMinutesInOven - x
    
// TODO: define the 'preparationTimeInMinutes' function
let preparationTimeInMinutes (x: int) =
    x * 2
    
// TODO: define the 'elapsedTimeInMinutes' function
let elapsedTimeInMinutes (x: int) (y: int) =
   (expectedMinutesInOven - remainingMinutesInOven y) + preparationTimeInMinutes x


    
    
    