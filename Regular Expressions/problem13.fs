//Problem 13: Write a program that recognizes valid hex color value using Regular Expression.
open System.Text.RegularExpressions

let regex = @"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$"
let result1 = Regex(regex).IsMatch("#fff")
let result2 = Regex(regex).IsMatch("#asdf")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

