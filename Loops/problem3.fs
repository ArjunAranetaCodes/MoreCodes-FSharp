
let word = "MoreCodes"
let mutable letterCount = 0

for letter in word do
 letterCount <- letterCount + 1

printfn "String Length: %i" letterCount

System.Console.ReadKey() |> ignore

