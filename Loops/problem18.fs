
let rec fibonacci(num:int) =
 if (num = 1) || (num = 0) then
  num
 else
  fibonacci (num - 1) + fibonacci (num - 2)

for x = 0 to 11 do
 let fib = fibonacci x
 printfn "%i" fib

System.Console.ReadKey() |> ignore

