(*
Problem 6: Write a program to print the number pattern of ones and zeros using loop.
11111
10001
10001
10001
11111
*)

for y = 0 to 4 do
 for x = 0 to 4 do
  if((y = 0) || (y = 4) || (x = 0) || (x = 4)) then
   printf "1"
  else
   printf "0"
 printfn ""

System.Console.ReadKey() |> ignore