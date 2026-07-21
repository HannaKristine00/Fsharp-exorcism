module InterestIsInteresting

let interestRate (balance: decimal): single =
    match balance with
        | n when n < 0 -> 3.213f
        | pl when pl >= 0 && pl < 1000 -> 0.5f
        | pgl when pgl >= 1000 && pgl < 5000 -> 1.621f
        | pge when pge >= 5000 -> 2.475f
    

let interest (balance: decimal): decimal =
    decimal (interestRate balance) / 100m * balance
    
let annualBalanceUpdate(balance: decimal): decimal =
    balance + interest balance

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    if balance > 0 then
        let amount = balance * (decimal taxFreePercentage / decimal 100 * decimal 2)
        int amount
    else
        let amount = 0
        amount
