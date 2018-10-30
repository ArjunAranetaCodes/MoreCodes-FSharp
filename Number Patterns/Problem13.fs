(*
Problem 13: Write a program to print the pattern of asterisks using loop.
*
**
***
****
*****
****
***
**
*
*)

let row = 4
for y = 0 to row do
 for x = 0 to y do
  printf "*"
 printfn ""

for y = row - 1 downto 0 do
 for x = 0 to y do
  printf "*"
 printfn ""

System.Console.ReadKey() |> ignore