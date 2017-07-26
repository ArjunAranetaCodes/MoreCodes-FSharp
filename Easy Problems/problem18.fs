//Problem 18: Write a program that outputs the frequency of a
//letter in a string.
let mutable word = "program"
let letter = "a"
let mutable letterCount = 0

for x = 0 to word.Length - 1 do
 if(letter.Contains(word.[x..x])) then
  letterCount <- letterCount + 1

printfn "Total: %i" letterCount
System.Console.ReadKey() |> ignore
