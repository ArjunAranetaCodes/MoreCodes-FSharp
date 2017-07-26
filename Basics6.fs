//Loop Structures
printfn("For To Loop")
for x = 0 to 10 do
 printf "%i" x

printfn("\nFor To Loop")
for x = 10 downto 1 do
 printf "%i" x

printfn("\nWhile Loop")
let mutable x = 0
while (x <= 10) do
 printf "%i" x
 x <- x + 1

System.Console.ReadKey() |> ignore
