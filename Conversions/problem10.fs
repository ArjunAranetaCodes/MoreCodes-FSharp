//Problem 10: Write a program that converts a decimal number to octal number.
let mutable dec = 256
let mutable oct = ""

while (dec > 0) do
 oct <- (dec % 8).ToString() + oct
 dec <- dec / 8

printf "%s" oct

System.Console.ReadKey() |> ignore