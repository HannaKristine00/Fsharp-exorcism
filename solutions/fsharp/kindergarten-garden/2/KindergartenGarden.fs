module KindergartenGarden


type Student =
    | Alice
    | Bob
    | Charlie
    | David
    | Eve
    | Fred
    | Ginny
    | Harriet
    | Ileana
    | Joseph
    | Kincaid
    | Larry

type Plant =
    | Grass
    | Clover
    | Radishes
    | Violets
    
let plants (diagram: string) student = 
    let aD = diagram.Split('\n')
    
    let index =
        match student with
        | "Alice" -> 0
        | "Bob" -> 1
        | "Charlie" -> 2
        | "David" -> 3
        | "Eve" -> 4
        | "Fred" -> 5
        | "Ginny" -> 6
        | "Harriet" -> 7
        | "Ileana" -> 8
        | "Joseph" -> 9
        | "Kincaid" -> 10
        | "Larry" -> 11
        
    let cToPlant (c: char) =
        match c with
        | 'G' -> Grass
        | 'C' -> Clover
        | 'R' -> Radishes
        | 'V' -> Violets

    [ cToPlant aD.[0].[2*index]
      cToPlant aD.[0].[2*index + 1]
      cToPlant aD.[1].[2*index]
      cToPlant aD.[1].[2*index + 1] ]    
    
    