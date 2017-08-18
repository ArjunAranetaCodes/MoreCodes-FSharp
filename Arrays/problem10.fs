
let arrNumbers = [|1;2;3|]
let sum = Array.sum arrNumbers

printfn "Average is %i" (sum/3)

System.Console.ReadKey() |> ignore

