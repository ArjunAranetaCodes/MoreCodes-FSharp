
let array1 = [|1;3;2;4|]
let sortarray = Array.sort array1
let array2 = Array.rev sortarray

for num in array2 do
 printfn "%i" num

System.Console.ReadKey() |> ignore

