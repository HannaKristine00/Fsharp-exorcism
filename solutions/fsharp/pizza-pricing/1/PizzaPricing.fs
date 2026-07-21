module PizzaPricing

type Pizza = 
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

    
let rec pizzaPrice (pizza: Pizza): int = 
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce p -> 1 + pizzaPrice p
    | ExtraToppings p -> 2 + pizzaPrice p

let orderPrice(pizzas: Pizza list): int = 
    let rec sum pp acc = 
        match pp with
        | [] -> acc
        | head :: tail ->  sum tail (pizzaPrice head + acc)
        
    match pizzas with
    | [] -> 0
    | [_] -> sum pizzas 0 + 3
    | [_; _] -> sum pizzas 0 + 2
    | _ -> sum pizzas 0
    
