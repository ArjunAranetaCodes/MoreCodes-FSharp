
let arrNumbers = [|1;2;3;4|]

for num in arrNumbers do
 if(num % 2 = 1) then
  printfn "%i" num

System.Console.ReadKey() |> ignore

