//Problem 4: Write a program that converts a string to array/list.
let numbers = "1,2,3"

let arrNumbers = numbers.Split ','

for value in arrNumbers do
    printfn "%s" value

System.Console.ReadKey() |> ignore