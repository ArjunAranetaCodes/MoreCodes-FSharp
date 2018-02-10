//Problem 5: Write a program that converts an array/list to string.
let arrNumbers = [| "1"; "2"; "3";|]
let numbers = 
    arrNumbers
    |> String.concat ", "

printf "%s" numbers

System.Console.ReadKey() |> ignore