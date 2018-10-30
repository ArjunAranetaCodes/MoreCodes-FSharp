(*
Problem 14: Write a program to print the number pattern using loop.
1
22
333
4444
55555
*)

for y = 1 to 5 do
 for x = 1 to y do
  printf "%i" y
 printfn ""

System.Console.ReadKey() |> ignore