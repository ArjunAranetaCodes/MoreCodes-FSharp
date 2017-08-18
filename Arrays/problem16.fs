
let arrNumbers = [|1;2;3|]

let remove x (xs : 'a array) =
    match Array.tryFindIndex ((=) x) xs with
    | Some 0 -> xs.[1..]
    | Some i -> Array.append xs.[..i-1] xs.[i+1..]
    | None   -> xs

let array2 = remove 2 arrNumbers

for num in array2 do
 printfn "%i" num

System.Console.ReadKey() |> ignore

