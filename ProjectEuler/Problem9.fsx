let sets = seq {
    for a = 1 to 1000 do
        for b = 1 to 1000 do
            for c = 1 to 1000 do
                if (a+b+c = 1000) then yield [a; b; c]
}

let isPythagoreanTriplet set = 
    match List.sort(set) with
    | [a; b; c] -> a*a + b*b = c*c
    | x -> false

let result = 
    sets
        |> Seq.filter isPythagoreanTriplet
        |> Seq.head
        |> Seq.fold (fun x y -> x * y) 1

printfn "%A" result
