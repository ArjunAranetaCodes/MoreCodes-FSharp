(*
Problem 3: Write a program to print the number pattern of ones and zeros using loop.
01010
01010
01010
01010
01010
*)
for y = 0 to 4 do
 for x = 0 to 4 do
  if (x % 2 = 0) then
   printf "0"
  else
   printf "1"
 printfn ""

System.Console.ReadKey() |> ignore