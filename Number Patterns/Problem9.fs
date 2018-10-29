(*
Problem 9: Write a program to print the number pattern of ones and zeros using loop.
11011
11011
00000
11011
11011
*)
let mutable row = 5
let mutable col = 5
for y = 0 to 4 do
 for x = 0 to 4 do
  if(col / 2 = x || row / 2 = y) then
   printf "0"
  elif((col % 2 = 0 && (col / 2) = x) || (row % 2 = 0 && (row / 2) = y)) then
   printf "0"
  else
   printf "1"
 printfn ""

System.Console.ReadKey() |> ignore