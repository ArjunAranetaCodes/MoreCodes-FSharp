
let num = 3333
let mutable sum = 0
let mutable temp = 0
let mutable rmdr = 0

temp <- num

while (temp <> 0) do
 rmdr <- temp % 10
 sum <- sum * 10 + rmdr
 temp <- temp / 10


if (num = sum) then
 printfn("Palindrome number")
else
 printfn("Not a Palindrome number")

System.Console.ReadKey() |> ignore
