
let arrNumbers = [|4;3;2;-1|]
let mutable closest = 0
let mutable numDiff = arrNumbers.[0]

for num in arrNumbers do
 let mutable diff = 0 - num
 diff <- abs diff
 if (diff < numDiff) then
  numDiff <- diff
  closest <- num

printfn "Closest to 0 is %i" closest

System.Console.ReadKey() |> ignore

