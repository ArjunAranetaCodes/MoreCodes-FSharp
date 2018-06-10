//Problem 10: Write a program that prints an integer with commas separator using Regular Expression.
open System.Text.RegularExpressions

let regex = @"(\d)(?=(\d{3})+$)"
let result1 = Regex.Replace("1000", regex, "$1,")
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

