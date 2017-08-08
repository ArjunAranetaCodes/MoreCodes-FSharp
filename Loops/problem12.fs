
let num1 = 3
let num2 = 5
let mutable prod = 0

for x = 1 to num2 do
 prod <- prod + num1

printfn "3 * 5 = %i" prod

System.Console.ReadKey() |> ignore
