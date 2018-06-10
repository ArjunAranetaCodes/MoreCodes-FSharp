//Problem 6: Write a program that removes white space and non-visible characters.
open System.Text.RegularExpressions

let regex = "\\s"
let result1 = Regex.Replace("Hello World", regex, "")
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

