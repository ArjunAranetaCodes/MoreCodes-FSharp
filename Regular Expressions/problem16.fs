//Problem 16: Write a program that takes a value inside a <a> tag using Regular Expression.
open System.Text.RegularExpressions

let regex = @"<([^""]*""|'[^']*'|[^'"">])*>"
let result1 = Regex.Replace("<a>Hello World</a>", regex, "")
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

