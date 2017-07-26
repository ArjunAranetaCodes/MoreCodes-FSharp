//If, ElseIf, and Else Structure
let num1 = 1
let num2 = 2

if (num1 > num2) then
 printfn "First number is higher!"

if (num1 = num2) then
 printfn "They are equal!"
else
 printfn "They are not equal!"

if (num1 > num2) then
 printfn "First number is greater!"
else if  (num2 > num1) then
 printfn "Second number is greater!"

System.Console.ReadKey() |> ignore
