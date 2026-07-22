module RolePlayingGame

type Player = { 
    Name: string option
    Level: int
    Health: int
    Mana: int option
}

let introduce (player: Player): string = 
    match player.Name with
    | Some name -> name
    | None -> "Mighty Magician"

let revive (player: Player): Player option = 
    if player.Health > 0 then
        None
    else
        if player.Level >= 10 then
            Some { player with Health = 100; Mana = Some 100 }
        else
            Some { player with Health = 100 }

let castSpell (manaCost: int) (player: Player): Player * int =
    match player.Mana with
    | Some mana when manaCost < mana -> ( { player with Mana = Some (mana - manaCost) }, manaCost * 2)
    | Some mana when manaCost > mana -> ( player, 0)
    | None -> 
        let newHealth =
            player.Health - manaCost
        if newHealth > 0 then 
            ( { player with Health = newHealth }, 0)
        else 
            ( { player with Health = 0 }, 0)
            
