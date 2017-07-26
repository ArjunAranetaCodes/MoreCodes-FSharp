//Problem 7: Write a program that finds the sum of all
//numbers from 1 to 20.
let mutable sum = 0

for x = 0 to 20 do
 sum <- sum + x

printf "The sum of 1 to 20 is %i" sum

System.Console.ReadKey() |> ignore
