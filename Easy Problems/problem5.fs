//Problem 5: Write a program that accepts that accepts temperature in
//Celcius and convert it to Farenheit.
let mutable celsius = 0.0

printf("Enter value of celsius: ")
celsius &lt;- System.Console.ReadLine() |> float

let farenheit = (9.0 / 5.0) * celsius + 32.0;

printfn "%fC equals to %fF" celsius farenheit

System.Console.ReadKey() |> ignore
