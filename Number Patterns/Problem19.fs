(*
Problem 19: Write a program to print the number pattern using loop.
11 11
11 11
   
11 11
11 11
*)
let row = 4
let col = 4
for y = 0 to row do
 for x = 0 to col do
  if(col / 2 = x || row / 2 = y) then
   printf " "
  elif((col % 2 = 0 && (col / 2) = x) || (row % 2 = 0 && (row / 2) = y)) then
   printf " "
  else
   printf "1"
 printfn ""

System.Console.ReadKey() |> ignore