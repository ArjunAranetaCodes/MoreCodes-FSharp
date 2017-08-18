
let arrNumbers = [|1;2;3|]

let indexOfNum  = Array.findIndex ((=)2) arrNumbers
printfn "%i" indexOfNum

System.Console.ReadKey() |> ignore

