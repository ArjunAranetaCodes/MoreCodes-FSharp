
let rec GetSum (num:int, sum:int) =
 if (num = 0) then
  sum
 else
  GetSum ((num - 1), (sum + num))

let res = GetSum(10,0)
printfn "Sum is %i " res

System.Console.ReadKey() |> ignore


