
//2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
//What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
open System

let numbers = seq {1 .. 20}
// evaluate prime factors
// evaluate smallest multiple
// apparently manilupating lists is not that easy in f#..


let decompose_prime n = 
  let rec loop c p =
    if c < (p * p) then [c]
    elif c % p = 0 then p :: (loop (c/p) p)
    else loop c (p + 1)
 
  loop n 2


let decomposed = numbers |> Seq.map(fun x -> decompose_prime x) 

decomposed |> Seq.iter(fun p -> printfn "%A" p)


//but there is always another way..
let divisibleByAll dividers number =
    dividers
    |> List.exists (fun d -> number % d <> 0)
    |> not

let smallestNumberDivisibleByAll dividers =
    let max = dividers |> List.max
    Seq.initInfinite ((+) 1 >> (*) max)
    |> Seq.find (divisibleByAll dividers)

let result =
    let dividers = [1 .. 20]
    smallestNumberDivisibleByAll dividers

printfn "%A" result

