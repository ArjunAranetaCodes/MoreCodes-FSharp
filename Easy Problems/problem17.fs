//Problem 17: Write a program that outputs the index
//of the first occurrence of the letter in a string.
let word = "program"
let letter = "a"

if (word.Contains(letter)) then
 printfn("Contains a")
else
 printfn("Does not contain a")

System.Console.ReadKey() |> ignore
