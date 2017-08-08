
let word = "MoreCodes"
let mutable newWord = ""

for x = word.Length - 1 downto 0 do
 newWord <- newWord + word.[x..x]

printfn "%s" newWord

System.Console.ReadKey() |> ignore
