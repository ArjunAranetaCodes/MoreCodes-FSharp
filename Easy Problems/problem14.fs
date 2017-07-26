//Problem 14: Write a program that replaces all letter
//a' in a string with letter 'e'
let word = "program"
let newWord = word.Replace("a", "e")

printfn "%s" newWord
System.Console.ReadKey() |> ignore
