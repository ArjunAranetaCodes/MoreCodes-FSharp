//Problem 5: Write a program that matches time in 24 hour format.
open System.Text.RegularExpressions

let regex = "^(0?[1-9]|1[012])(:[0-5]\\d) [APap][mM]$"
let result1 = Regex(regex).IsMatch("25:00 am")
let result2 = Regex(regex).IsMatch("08:01 am")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

