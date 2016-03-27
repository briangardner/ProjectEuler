open System
let getUpperBound number = int64(Math.Sqrt(double(number)))

let isFactor number factorCandidate =
    number % factorCandidate = 0L

let factors number = seq {
    for i in [2L ..getUpperBound number] do
        if isFactor number i then yield i 
    }

let isPrime number =
    factors number |> Seq.length = 0

let sumOfPrimes number = 
    [2L .. number]
    |> Seq.filter isPrime
    |> Seq.sum

let result = sumOfPrimes 2000000L

printfn "%A" result
