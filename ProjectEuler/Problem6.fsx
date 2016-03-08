let square x = x*x

let sumOfSquares numbers = 
    let min = Seq.min numbers
    let max = Seq.max numbers
    Seq.unfold (fun x -> if (x > max) then None else Some(square x, x+1)) min
        |> Seq.sum

let squareOfSums numbers =
    numbers
        |> Seq.sum
        |> square

let result =
    abs (sumOfSquares [1..100] - squareOfSums [1..100])

printfn "%A" result