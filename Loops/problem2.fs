
let rand  = new System.Random()

for x = 0 to 4 do
 let num = rand.Next(9)
 printfn "%i" num

System.Console.ReadKey() |> ignore
