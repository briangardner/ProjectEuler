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

let maxPrime number = 
    [2L .. getUpperBound number]
    |> Seq.filter (fun x -> isFactor number x)
    |> Seq.filter isPrime
    |> Seq.max

let max = 
    maxPrime 600851475143L

printfn "%A" max
