//Problem 9: Write a program that checks if the string is alphanumeric using Regular Expression.
open System.Text.RegularExpressions

let regex = @"(([A-Z].*[0-9])|([0-9].*[A-Z]))"
let result1 = Regex(regex).IsMatch("HelloWorld")
let result2 = Regex(regex).IsMatch("HelloWorld123")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

