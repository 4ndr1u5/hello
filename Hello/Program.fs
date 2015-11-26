<<<<<<< master
﻿// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System


[<EntryPoint>]
let main argv = 
    let name = Console.ReadLine();
    printfn "Hello %s" name



    let numbers = seq { 0 .. 1000 }
    let filter a numbers = numbers 
                        |> Seq.filter (fun x -> x%a <> 0)

    let result = Array.sum (numbers
                |> (filter 3)
                |> (filter 5)
                |> Seq.toArray)
    printfn "Hello %A" result


    Console.ReadLine(); 
    0 // return an integer exit code

    
=======
﻿// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System


[<EntryPoint>]
let main argv = 
    let name = Console.ReadLine();
    printfn "Hello %s" name

    let tokenize number = let word = number.ToString()
                          word.ToCharArray() |> Array.toList


    let isPalindrome l = let tokenized = tokenize l
                         List.rev tokenized = tokenized


                            
    let allPalindromes = seq {10000.. 1000000} |> Seq.filter(fun x -> isPalindrome x)

    printfn "%A" (allPalindromes)
    Console.ReadLine(); 
    0 // return an integer exit code




    
>>>>>>> local
