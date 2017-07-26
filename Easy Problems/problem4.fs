//Problem 4:Write a program that accepts radius of a circle and
//find its diameter, circumference, and area.
let mutable radius = 0.0
let mutable PI = 3.14

printf("Enter value of radius: ")
radius &lt;- System.Console.ReadLine() |> float

let dia = radius * radius;
let area = PI * dia;
let cir = 2.0 * PI * radius;

printfn "Diameter of circle is %f" dia
printfn "Area of circle is %f" area
printfn "Circumference of circle is %f" cir

System.Console.ReadKey() |> ignore
