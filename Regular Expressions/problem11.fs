//Problem 11: Write a program that counts the occurrence of a string in a string using Regular Expression.
open System.Text.RegularExpressions

let regex = @"Hello"
let result1 = Regex.Matches("HelloWorldHelloWorld", regex).Count
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

