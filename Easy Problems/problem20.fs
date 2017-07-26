//Problem 20: Write a program that checks if a string is a
//palindrome.
let word = "anna"
let ReverseString (s:string) = new string(Array.rev (s.ToCharArray()))
let tempWord = ReverseString word

if (word = tempWord) then
 printfn("Palindrome")
else
 printfn("Not Palindrome")
System.Console.ReadKey() |> ignore
