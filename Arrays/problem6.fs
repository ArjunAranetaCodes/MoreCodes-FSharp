
let arrNumbers = [|1;2;3|]
let mutable count = 0

for num in arrNumbers do
 if (num = 2) then
  count <- count + 1

if(count > 0) then
 printfn("Contains 2")
else
 printfn("Does not contain 2")

System.Console.ReadKey() |> ignore

