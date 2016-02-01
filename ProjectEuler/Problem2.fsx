let rec generateFibs a b max = 
    if a + b < max then
        let current = a + b
        let rest = generateFibs b current max
        current :: rest
    else
        []
let fibonacci = 1::2::generateFibs 1 2 4000000

let sumOfEvens list = 
    list 
    |> List.filter(fun x -> x % 2 = 0)
    |> List.sum

let answer = sumOfEvens fibonacci
printfn "%A" answer

        
