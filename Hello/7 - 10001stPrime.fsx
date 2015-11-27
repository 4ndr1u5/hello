//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//
//What is the 10 001st prime number?


open System
 
let isPrime x =
    let rec check i =
        x > 1L &&
       (double i > sqrt (double x) || (x % i <> 0L && check (i + 1L)))
    check 2L                
 
let firstPrimes n =
    Seq.initInfinite (fun x -> int64 x)
    |> Seq.filter isPrime
    |> Seq.take n
    |> Seq.max

let result = firstPrimes 10001

printfn "%A" result