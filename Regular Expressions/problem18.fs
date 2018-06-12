//Problem 18: Write a program that extracts string inside quotation marks using Regular Expression.
open System.Text.RegularExpressions

let regex = @"'([^""]*)'"
let result1 = Regex.Matches("Hello 'World'", regex).[0].ToString()
printfn "%s" (result1.ToString())

System.Console.ReadKey() |> ignore

