module BirdWatcher

let lastWeek: int[] = [| 0; 2; 5; 3; 7; 8; 4 |]
   

let yesterday(counts: int[]): int =
    let idx = counts |> Array.length
    let y = idx - 2
    counts[y]

let total(counts: int[]): int =
  let added = counts |> Array.sum
  added

let dayWithoutBirds(counts: int[]): bool =
  let zero = counts |> Array.contains 0
  zero

let incrementTodaysCount(counts: int[]): int[] =
    let idx = counts |> Array.length
    let y = idx - 1
    let value = counts[y]
    let incremented = value + 1
    counts[y] <- incremented
    counts
    
let unusualWeek(counts: int[]): bool =
    match counts with
        | ez when ez[1] = 0 && ez[3] = 0 && ez[5] = 0 -> true
        | et when et[1] = 10 && et[3] = 10 && et[5] = 10 -> true
        | o when o[0] = 5 && o[2] = 5 && o[4] = 5 && o[6] = 5 -> true
        | _ -> false
