//Problem 7: Write a program that counts vowels in a String using Regular Expression.
open System.Text.RegularExpressions

let regex = "[^aeiouAEIOU]"
let result1 = Regex.Replace("Hello World", regex, "").Length
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

