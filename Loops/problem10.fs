
let num = 371
let mutable sum = 0
let mutable temp = 0
let mutable rmdr = 0

temp <- num

while (temp <> 0) do
 rmdr <- temp % 10
 sum <- sum + (rmdr * rmdr * rmdr)
 temp <- temp / 10


if (num = sum) then
 printfn("Armstrong number")
else
 printfn("Not an Armstrong number")

System.Console.ReadKey() |> ignore
