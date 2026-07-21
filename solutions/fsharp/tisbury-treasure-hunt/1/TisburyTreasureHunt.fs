module TisburyTreasureHunt

let getCoordinate (line: string * string): string =
    let coor = snd line 
    coor

let convertCoordinate (coordinate: string): int * char = 
    let cc = (System.Int32.Parse(string coordinate[0]), char coordinate[1])
    cc
    

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let (aTreasure, aCoordinates) = azarasData
    let aCoordinates = convertCoordinate aCoordinates
    let (rLocation, rCoordinate, rQuandrant) = ruisData

    aCoordinates = rCoordinate
    
    
    
let createRecord (azarasData: string * string) (ruisData: string * (int * char) * string) : (string * string * string * string) =
    if compareRecords azarasData ruisData then
        let (aTreasure, aCoordinates) = azarasData
        let (rLocation, rCoordinate, rQuandrant) = ruisData
        let record = (aCoordinates, rLocation, rQuandrant, aTreasure)
        record
    else ("", "", "", "")
