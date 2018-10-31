(*
Problem 17: Write a program to print the number pattern using loop.
1
12
123
1234
12345
1234
123
12
1
*)
let row = 4
for y = 0 to row do
 for x = 0 to y do
  printf "%i" (x + 1)
 printfn ""

for y = row - 1 downto 0 do
 for x = 0 to y do
  printf "%i" (x + 1)
 printfn ""

System.Console.ReadKey() |> ignore