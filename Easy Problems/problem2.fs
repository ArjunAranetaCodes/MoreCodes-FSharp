//Problem 2: Write a program that accepts two numbers
//and perform all arithmetic operations.
let mutable num1 = 0
let mutable num2 = 0

printf("Enter num1 value: ")
num1 &lt;- System.Console.ReadLine() |> int
printf("Enter num2 value: ")
num2 &lt;- System.Console.ReadLine() |> int
let sum = num1 + num2
let diff = num1 - num2
let prod = num1 * num2
let quot = num1 / num2

printfn "Sum is %d" sum
printfn "Difference is %d" diff
printfn "Product is %d" prod
printfn "Quotient is %d" quot

System.Console.ReadKey() |> ignore
