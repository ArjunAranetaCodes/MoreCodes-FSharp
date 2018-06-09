//Problem 4: Write a program that matches time in 12 hour format.
open System.Text.RegularExpressions

let regex = "(((0[1-9])|(1[0-2])):([0-5])([0-9])\\s(a|p)m)"
let result1 = Regex(regex).IsMatch("08:00 am")
let result2 = Regex(regex).IsMatch("18:00 pm")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

