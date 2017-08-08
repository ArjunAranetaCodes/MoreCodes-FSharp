
let mutable num1 = 1
let mutable num2 = 1

printfn "%i" num1
while (num2 < 100) do
 printfn "%i" num2
 num2 <- num2 + num1
 num1 <- num2 - num1

System.Console.ReadKey() |> ignore
