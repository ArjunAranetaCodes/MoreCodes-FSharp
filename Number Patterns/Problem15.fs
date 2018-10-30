(*
Problem 15: Write a program to print the number pattern using loop.
11111
2222
333
44
5
*)
let mutable row = 4
let mutable num = 1
for y = row downto 0 do
 for x = 0 to y do
  printf "%i" num
 num <- num + 1
 printfn ""

System.Console.ReadKey() |> ignore