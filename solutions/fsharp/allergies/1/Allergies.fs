module Allergies

open System

type Allergen =
    | Eggs
    | Peanuts
    | Shellfish
    | Strawberries
    | Tomatoes
    | Chocolate
    | Pollen
    | Cats

let allergicTo codedAllergies allergen = 
    let value =
        match allergen with
        | Eggs -> 1
        | Peanuts -> 2
        | Shellfish -> 4
        | Strawberries -> 8
        | Tomatoes -> 16
        | Chocolate -> 32
        | Pollen -> 64
        | Cats -> 128
    codedAllergies &&& value <> 0

let list codedAllergies = 
    [Eggs; Peanuts; Shellfish; Strawberries; Tomatoes; Chocolate; Allergen.Pollen; Allergen.Cats]
    |>
    List.filter(allergicTo codedAllergies)
        
        