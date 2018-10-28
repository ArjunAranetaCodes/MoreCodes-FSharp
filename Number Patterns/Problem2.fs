(*
Problem 2: Write a program to print the number pattern of ones and zeros using loop.
11111
00000
11111
00000
11111
*)

for y = 0 to 4 do
 for x = 0 to 4 do
  if (y % 2 = 0) then
   printf "1"
  else
   printf "0"
 printfn ""

System.Console.ReadKey() |> ignore