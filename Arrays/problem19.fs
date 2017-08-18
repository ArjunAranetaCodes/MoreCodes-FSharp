
let array1 = [|1;2;3|]
let array2 = [|1;2;3|]
let newarray = Array.append array1 array2

for num in newarray do
 printfn "%i" num

System.Console.ReadKey() |> ignore

