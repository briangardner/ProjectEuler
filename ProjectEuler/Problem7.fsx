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

let findNthPrime position =
    Seq.initInfinite (fun x -> int64 x)
        |> Seq.filter isPrime
        |> Seq.item (position+1)

let result = findNthPrime 10001

printfn "%A" result 


