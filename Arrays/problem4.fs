
let arrNumbers = [|1;2;3|]

printfn "%i" arrNumbers.[0]
printfn "%i" arrNumbers.[arrNumbers.Length - 1]

System.Console.ReadKey() |> ignore

