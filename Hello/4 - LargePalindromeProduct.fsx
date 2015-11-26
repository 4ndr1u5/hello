//A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-d igit numbers is 9009 = 91 × 99.
//Find the largest palindrome made from the product of two 3-digit numbers.

open System

let tokenize number = let word = number.ToString()
                      word.ToCharArray() |> Array.toList

let isPalindrome l = let tokenized = tokenize l
                     List.rev tokenized = tokenized

let numbersInRange = [100.. 999]

let cartesian xs ys = 
    xs |> List.collect (fun x -> ys |> List.map (fun y -> x, y))

let multiples = (cartesian numbersInRange numbersInRange) |> Seq.map(fun (x,y) -> x*y)
let palindromes = multiples |> Seq.filter(fun x -> isPalindrome x)

let result = palindromes |> Seq.max

printfn "%A" result