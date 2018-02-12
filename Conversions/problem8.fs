//Problem 8: Write a program that converts a decimal number to hexadecimal number.
let mutable dec = 256
let mutable hex = ""

while (dec > 0) do
 hex <- (dec % 16).ToString() + hex
 dec <- dec / 16

printf "%s" hex

System.Console.ReadKey() |> ignore