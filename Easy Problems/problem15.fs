//Problem 15: Write a program that finds if a string is
//within a string.
let word = "programming"
let strSearch = "program"

if word.Contains(strSearch) then
 printfn "%s found" strSearch
else
 printfn "%s not found" strSearch

System.Console.ReadKey() |> ignore
