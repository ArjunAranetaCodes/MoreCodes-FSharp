//Problem 20: Write a program that validates if string length is between 5 to 10 using Regular Expression.
open System.Text.RegularExpressions

let regex = @"\w{5,10}\b"
let result1 = Regex(regex).IsMatch("Hello World")
let result2 = Regex(regex).IsMatch("Hi")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

