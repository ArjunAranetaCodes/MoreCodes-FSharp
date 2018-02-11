//Problem 7: Write a program that converts a decimal number to binary number.
let mutable dec = 10
let mutable binary = ""

while (dec > 0) do
 binary <- (dec % 2).ToString() + binary
 dec <- dec / 2

printf "%s" binary

System.Console.ReadKey() |> ignore