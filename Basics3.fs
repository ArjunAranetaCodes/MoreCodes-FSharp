//Variables and Input
let mutable name = ""
let mutable sex = ""
let mutable age = 0

printf("What is your name? ")
name <- System.Console.ReadLine()
printf("What is your sex? (M or F) ")
sex <- System.Console.ReadLine()
printf("What is your age? ")
age <- System.Console.ReadLine() |> int

printfn "Name: %s" name
printfn "Sex: %s" sex
printfn "Age: %d" age

System.Console.ReadKey() |> ignore
