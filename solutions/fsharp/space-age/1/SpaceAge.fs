module SpaceAge

type Planet =
    | Mercury 
    | Venus
    | Earth
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune 

let age (planet: Planet) (seconds: int64): float = 
    let earthYear = 31557600.0
    let s = float seconds
    
    match planet with
    | Mercury -> s / (0.2408467 * earthYear)
    | Venus -> s / (0.61519726 * earthYear)
    | Earth -> s / (1.0 * earthYear)
    | Mars -> s / (1.8808158 * earthYear)
    | Jupiter -> s / (11.862615 * earthYear)
    | Saturn -> s / (29.447498 * earthYear)
    | Uranus -> s / (84.016846 * earthYear)
    | Neptune -> s / (164.79132 * earthYear)

