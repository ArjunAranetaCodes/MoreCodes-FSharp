
let arrNumbers = [|1;1;2;3|]
let mutable count = 0

for num in arrNumbers do
 if (num = 1) then
  count <- count + 1

printfn "Occurence: %i" count

System.Console.ReadKey() |> ignore

