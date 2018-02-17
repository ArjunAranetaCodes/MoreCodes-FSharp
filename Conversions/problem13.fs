//Problem 13: Write a program that converts celsius to farenheit.
let mutable celsius = 0.0

printf("Enter value of celsius: ")
celsius <- System.Console.ReadLine() |> float

let farenheit = (9.0 / 5.0) * celsius + 32.0;

printfn "%fC equals to %fF" celsius farenheit

System.Console.ReadKey() |> ignore