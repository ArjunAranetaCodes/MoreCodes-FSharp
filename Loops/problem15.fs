
let mutable num = 0

while num > -1 do
 printf("Enter a number: ")
 num <- System.Console.ReadLine() |> int

printfn "Terminated"

System.Console.ReadKey() |> ignore
