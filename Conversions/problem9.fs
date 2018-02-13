//Problem 9: Write a program that converys a hexadecimal number to decimal number.
let mutable dec = 0
let mutable hex = "100"

let ReverseString (s:string) = new string(Array.rev (s.ToCharArray()))
hex <- ReverseString hex

for x = 0 to hex.Length - 1 do
 if(hex.[x] = '1') then
  dec <- dec + (pown 16 x)

printf "%d" dec

System.Console.ReadKey() |> ignore