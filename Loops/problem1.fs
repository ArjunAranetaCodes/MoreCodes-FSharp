
for x = 1 to 50 do
 if (x % 3 = 0) && (x % 5 = 0) then
  printfn("FizzBuzz")
 else if (x % 3 = 0) then
  printfn("Fizz")
 else if (x % 5 = 0) then
  printfn("Buzz")
 else
  printfn "%i" x

System.Console.ReadKey() |> ignore
