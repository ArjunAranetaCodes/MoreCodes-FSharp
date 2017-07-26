//Problem 10: Write a program that accepts three numbers
//and outputs their average.
let mutable num1 = 0
let mutable num2 = 0
let mutable num3 = 0
let mutable ave = 0

printf("Enter num1 value: ")
num1 <- System.Console.ReadLine() |> int
printf("Enter num2 value: ")
num2 <- System.Console.ReadLine() |> int
printf("Enter num3 value: ")
num3 <- System.Console.ReadLine() |> int
ave <- (num1 + num2 + num3) / 3

printfn "Average is %d" ave

System.Console.ReadKey() |> ignore
