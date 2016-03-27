open System.IO
let numbers =
    File.ReadAllLines("Problem11.txt")
    |> Seq.map ( fun x -> x.Split(' ') |> Seq.map int32 |> Seq.toArray)
    |> Seq.toArray

