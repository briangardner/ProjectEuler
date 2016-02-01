let numbers = [0..999]

let sumMultipleThreesAndFives (list:List<int>) = 
    list
    |> List.filter (fun x -> (x % 3 = 0) || (x % 5 = 0))
    |> List.sum

let answer = sumMultipleThreesAndFives numbers
printfn "%A" answer
