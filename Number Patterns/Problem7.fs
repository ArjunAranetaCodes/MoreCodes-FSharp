(*
Problem 7: Write a program to print the number pattern of ones and zeros using loop.
10101
01010
10101
01010
10101
*)

let mutable count = 0
for y = 0 to 4 do
 for x = 0 to 4 do
  count <- count + 1
  if (count % 2 = 1) then
   printf "1"
  else
   printf "0"
 printfn ""

System.Console.ReadKey() |> ignore