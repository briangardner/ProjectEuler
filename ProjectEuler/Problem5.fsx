let isFactor(number, divisor) = number % divisor = 0

let areAllFactors (number, numbers) = 
    numbers |> Seq.forall (fun n -> isFactor(number, n))

let smallestMultipleForAll numbers =
    let max = Seq.max numbers
    Seq.unfold (fun start -> Some(start, start + max)) max
        |> Seq.filter (fun n -> areAllFactors (n, numbers))
        |> Seq.head

let result = smallestMultipleForAll [1..20]

printfn "%A" result