//Problem 12: Write a program that asks a user for their
//name and outputs a greeting with their name.
let mutable name = ""

printf("Enter name: ")
name <- System.Console.ReadLine()

printfn "Hello %s" name
System.Console.ReadKey() |> ignore
