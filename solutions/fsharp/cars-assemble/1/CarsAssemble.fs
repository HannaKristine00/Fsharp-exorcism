module CarsAssemble

let successRate (speed: int): float =
    if speed = 0 then
        0.0
    else if speed >= 1 && speed <= 4 then
        1.0
    else if speed >= 5 && speed <= 8 then
        0.90
    else if speed = 9 then
        0.8
    else 0.77
        
let productionRatePerHour (speed: int): float =
    let cars: float = 221.0
    let rate: float = successRate speed
    let speed: float = speed
    (speed * cars) * rate

    
let workingItemsPerMinute (speed: int): int = 
    let prodRate = productionRatePerHour speed
    let carsPerHour = int prodRate
    let carsPerMin: int = carsPerHour / 60
    carsPerMin
    