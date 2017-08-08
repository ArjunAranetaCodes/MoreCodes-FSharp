
let mutable num = 0
let mutable sum = 0
let mutable ave = 0

for x = 0 to 4 do
 printf("Enter a number: ")
 num <- System.Console.ReadLine() |> int
 sum <- sum + num

ave <- sum / 5
printfn "Average is %i " ave

System.Console.ReadKey() |> ignore
