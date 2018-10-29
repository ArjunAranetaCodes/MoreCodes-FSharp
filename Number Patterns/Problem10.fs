(*
Problem 10: Write a program to print the number pattern using loop.
12345
23456
34567
45678
56789
*)
let mutable row = 5
let mutable col = 5
let mutable min = 1

for y = 0 to 4 do
 let mutable num = min + y
 for x = 0 to 4 do
  printf "%i" num
  num <- num + 1
 printfn ""

System.Console.ReadKey() |> ignore