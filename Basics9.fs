//Basics of Functions
let function1 =
 printfn "Hello There"

let function2 (num:int) =
 printfn "That number is %d" num

let function3 =
 let sum = 1 + 1
 sum

let function4 (firstName:string) (lastName:string) =
 let fullName = firstName + " " + lastName
 fullName

function1
function2 5
printfn "It's true! 1 + 1 = %d" function3
printfn "Hi! %s" (function4 "More" "Codes")

System.Console.ReadKey() |> ignore
