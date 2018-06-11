//Problem 15: Write a program that takes a value inside a <div> tag using Regular Expression.
open System.Text.RegularExpressions

let regex = @"<([^""]*""|'[^']*'|[^'"">])*>"
let result1 = Regex.Replace("<div>Hello World</div>", regex, "")
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

