(*
Problem 12: Write a program to print the pattern of asterisks using loop.
*****
****
***
**
*
*)

let mutable row = 4
for y = row downto 0 do
 for x = 0 to y do
  printf "*"
 printfn ""

System.Console.ReadKey() |> ignore