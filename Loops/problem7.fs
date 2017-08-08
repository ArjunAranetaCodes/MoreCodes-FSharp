
let n = 10
let mutable sum = 0

for x = 0 to n do
 sum <- sum + x

printfn "Sum is %i " sum

System.Console.ReadKey() |> ignore
