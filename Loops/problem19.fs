
let rec PrintEven(num:int) =
   if (num = 0) then
    num
   else
    if (num % 2 = 0) then
     printfn "%i" num
    PrintEven (num - 1)

let res = PrintEven(10)

System.Console.ReadKey() |> ignore


