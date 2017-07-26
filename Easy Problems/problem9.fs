//Problem 9: Write a program that accepts a number
//and outputs 1 to the input (1 to n).
let mutable num = 0
let mutable sum = 0

printf("Enter value of num: ")
num <- System.Console.ReadLine() |> int

for x = 0 to num do
 sum <- sum + x

printfn "The sum of 1 to %d is %d" num sum

System.Console.ReadKey() |> ignore
