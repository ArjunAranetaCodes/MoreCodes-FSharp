//Problem 19: Write a program that counts all numbers in a string using Regular Expression.
open System.Text.RegularExpressions

let regex = @"[^0-9]"
let result1 = Regex.Replace("Hello World123", regex, "").Length
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

