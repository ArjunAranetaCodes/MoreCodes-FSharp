//Problem 19: Write a program that counts the total number
//of vowels in a string.
let mutable word = "program"
let vowels = "aeiou"
let mutable vowelCount = 0

for x = 0 to word.Length - 1 do
 if(vowels.Contains(word.[x..x])) then
  vowelCount <- vowelCount + 1

printfn "Total: %i" vowelCount
System.Console.ReadKey() |> ignore
