
let mutable word = "program"
let vowels = "aeiou"
let mutable vowelCount = 0

for x = 0 to word.Length - 1 do
 if(vowels.Contains(word.[x..x])) then
  vowelCount <- vowelCount + 1

printfn "Total: %i" vowelCount
System.Console.ReadKey() |> ignore
