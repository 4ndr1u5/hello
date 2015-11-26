//The prime factors of 13195 are 5, 7, 13 and 29.
//What is the largest prime factor of the number 600851475143 ?
open Microsoft.FSharp.Core.NumericLiterals

//not optimal
let rec sieve = function
    | (p::xs) -> p :: sieve [ for x in xs do if x % p > 0 then yield x ]
    | []      -> []

//let number = 600851475143
let number = 600851475
let numbers = [ 2 ..   number/2 ]
//let numbers:List<int64> = [ 2L ..  number ]
let primes = sieve numbers

let primeFactors number =
    let mutable xs = [1]
    for i in primes do
        if number%i=0 then xs <- i::xs
    xs

let biggestPrimeFactor = (primeFactors number)
                        |> List.max
printfn "%A" biggestPrimeFactor

//more optimal, still needs improvement
open System.Numerics

let isPrime (x:int64) = let mutable prime = true;
                        for i in seq {2L.. x/2L} do
                            if int64 x % int64 i = 0L then prime <- false
                        prime

let findFactors ofNumber =
           {2L .. (ofNumber/2L)}
           |> Seq.filter(fun testNumber -> ofNumber % testNumber = 0L)
           |> Seq.map(fun factor1 -> (factor1, (ofNumber / factor1)))
           |> Seq.takeWhile(fun (factor1, factor2) -> factor1 <= factor2)
           |> Seq.fold (fun acc (factor1, factor2) -> factor1 :: factor2 :: acc) []
           |> Seq.sort

let primeFactors2 (factors:List<int64>) = factors |> List.filter(fun x -> isPrime x)
//600851475143L
let answer = findFactors 600851475143L |> Seq.toList |> primeFactors2 |> List.max

printfn "Hello %A" answer