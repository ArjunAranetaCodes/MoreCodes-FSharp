//Problem 3: Write a program that accepts length and
//width of rectangle to find area.
let mutable length = 0
let mutable width = 0

printf("Enter length value: ")
length &lt;- System.Console.ReadLine() |> int
printf("Enter width value: ")
width &lt;- System.Console.ReadLine() |> int
let area = length * width

printfn "Area of Rectangle is %d" area

System.Console.ReadKey() |> ignore
