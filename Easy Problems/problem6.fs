//Problem 6: Write a program that checks a number
//input is even or odd.
let mutable num = 0

printf("Enter value of num: ")
num <- System.Console.ReadLine() |> int

if (num % 2 = 0) then
 printfn("Number is even")
else
 printfn("Number is odd")

System.Console.ReadKey() |> ignore
