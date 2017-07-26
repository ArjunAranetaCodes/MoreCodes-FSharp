//Problem 1: Write a program that accepts
//two numbers and find the sum.
let mutable num1 = 0
let mutable num2 = 0

printf("Enter num1 value: ")
num1 &lt;- System.Console.ReadLine() |> int
printf("Enter num2 value: ")
num2 &lt;- System.Console.ReadLine() |> int
let sum = num1 + num2

printfn "Sum is %d" sum

System.Console.ReadKey() |> ignore
