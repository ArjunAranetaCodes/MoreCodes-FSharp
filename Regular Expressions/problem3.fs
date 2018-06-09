//Problem 3: Write a program that checks if string contains sample format date of (yyyy-mm-dd)
open System.Text.RegularExpressions

let regex = "([0-9]{4})-([0-9]{2})-([0-9]{2})"
let result1 = Regex(regex).IsMatch("2018-01-02")
let result2 = Regex(regex).IsMatch("01-01-02")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

