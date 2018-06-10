//Problem 8: Write a program that checks if the String if valid url using Regular Expression.
open System.Text.RegularExpressions

let regex = @"^(https?:\/\/)?(www\.)?([\w]+\.)+[‌​\w]{2,63}\/?$"
let result1 = Regex(regex).IsMatch("http://www.example.com")
let result2 = Regex(regex).IsMatch("wwwexamplecom")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

