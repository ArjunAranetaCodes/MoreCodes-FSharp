//Problem 1: Write a program to test if the first character of the String is uppercase.
open System.Text.RegularExpressions

let regex = "^[A-Z][a-z0-9_-]{3,19}$"
let result1 = Regex(regex).IsMatch("Hello")
let result2 = Regex(regex).IsMatch("world")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

