(*
Problem 20: Write a program to print the number pattern using loop.
  1
 222
33333
 444
  5
*)

let rows = 3
let mutable nums = 1
let mutable blank = rows - 1

for y = 1 to rows * 2 do
 for x = 1 to blank do
  printf " "

 for x = 1 to (nums * 2) - 1 do
  printf "%i" y
 
 if (y < rows) then
  blank <- blank - 1
  nums <- nums + 1
 else
  blank <- blank + 1
  nums <- nums - 1

 printfn ""

System.Console.ReadKey() |> ignore