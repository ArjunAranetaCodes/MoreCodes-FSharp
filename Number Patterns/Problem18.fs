(*
Problem 18: Write a program to print the number pattern using loop.
  1  
 111
11111
 111
  1
*)

let rows = 3
let mutable ones = 1
let mutable blank = rows - 1

for y = 1 to rows * 2 do
 for x = 1 to blank do
  printf " "

 for x = 1 to (ones * 2) - 1 do
  printf "1"
 
 if (y < rows) then
  blank <- blank - 1
  ones <- ones + 1
 else
  blank <- blank + 1
  ones <- ones - 1

 printfn ""

System.Console.ReadKey() |> ignore