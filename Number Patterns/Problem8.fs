(*
Problem 8: Write a program to print the number pattern of ones and zeros using loop.
11111
11111
11011
11111
11111
*)

let mutable row = 5
let mutable col = 5
for y = 0 to 4 do
 for x = 0 to 4 do
  if(x = (row / 2) && y = (col / 2)) then
   printf "0"
  else
   printf "1"
 printfn ""

System.Console.ReadKey() |> ignore