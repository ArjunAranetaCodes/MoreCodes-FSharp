//Problem 2: Write a program that matches email address.
open System.Text.RegularExpressions

let regex = "^[_A-Za-z0-9-+]+(.[_A-Za-z0-9-]+)*@[A-Za-z0-9-]+(.[A-Za-z0-9]+)*(.[A-Za-z]{2,})$"
let result1 = Regex(regex).IsMatch("mark@yahoo.com")
let result2 = Regex(regex).IsMatch("mark-yahoo.com")
printfn "%s" (result1.ToString())
printfn "%s" (result2.ToString())

System.Console.ReadKey() |> ignore

