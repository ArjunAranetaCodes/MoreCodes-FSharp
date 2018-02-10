//Problem 6: Write a program that converts a binary number to decimal number.
let mutable dec = 0
let mutable binary = "110"

let ReverseString (s:string) = new string(Array.rev (s.ToCharArray()))
binary <- ReverseString binary

for x = 0 to binary.Length - 1 do
 if(binary.[x] = '1') then
  dec <- dec + (pown 2 x)

printf "%d" dec

System.Console.ReadKey() |> ignore