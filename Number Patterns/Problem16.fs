(*
Problem 16: Write a program to print the number pattern using loop.
12345
1234
123
12
1
*)
let mutable row = 4
for y = row downto 0 do
 for x = 0 to y do
  printf "%i" (x + 1)
 printfn ""

System.Console.ReadKey() |> ignore