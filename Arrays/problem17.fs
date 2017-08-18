
let array1 = [|1;2;3|]
let array2 = Array.append array1 [|5|]

for num in array2 do
 printfn "%i" num

System.Console.ReadKey() |> ignore

