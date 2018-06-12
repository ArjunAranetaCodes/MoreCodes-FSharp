//Problem 17: Write a program that removes the last word in a string using Regular Expression.
open System.Text.RegularExpressions

let regex = @"\w+$"
let result1 = Regex.Replace("Hello World", regex, "")
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

