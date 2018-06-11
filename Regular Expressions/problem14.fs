//Problem 14: Write a program that recognizes valid hex color value using Regular Expression.
open System.Text.RegularExpressions

let regex = @"^([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])\.([01]?\d\d?|2[0-4]\d|25[0-5])$"
let result1 = Regex(regex).IsMatch("192.168.1.1")
let result2 = Regex(regex).IsMatch("1.1.1.1.1")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

