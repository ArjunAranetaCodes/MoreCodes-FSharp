
let array1 = [|1;2;3|]
let array2 = [|1;2;3|]

if(array1 = array2) then
 printfn("Equal Arrays")
else
 printfn("Not Equal")

System.Console.ReadKey() |> ignore

