//Problem 8: Write a program that outputs all numbers divisible by
//5 from 1 to 30.
let mutable sum = 0

for x = 0 to 30 do
 if (x % 5 = 0) then
  sum <- sum + x

printf "The sum of numbers divisible by 5 from 1 to 30 is %i" sum

System.Console.ReadKey() |> ignore
