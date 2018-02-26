//Problem 20: Write a program that converts a number to its 
//corresponding month (e.g. 1 = January).

let index = 1
let month = [|"January"; "February"; "March"; "April";
"May"; "June"; "July"; "August";
"September"; "October"; "November"; "December"|]

printf "%s" month.[index - 1]

System.Console.ReadKey() |> ignore