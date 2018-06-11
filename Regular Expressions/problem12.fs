//Problem 12: Write a program that counts the occurrence of digits in a string using Regular Expression.
open System.Text.RegularExpressions

let regex = @"\D"
let result1 = Regex.Replace("Hello12 World12", regex, "").Length
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

