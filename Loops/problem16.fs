
let num = 5
let mutable fact = 1

for x = num downto 1 do
 fact <- fact * x

printfn "Factorial of 5 is %i" fact
System.Console.ReadKey() |> ignore

