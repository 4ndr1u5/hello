//The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
//Find the sum of all the primes below two million.
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

let sumPrimesUpTo(n) = Seq.initInfinite (fun x -> int64 x)
                            |> Seq.take n
                            |> Seq.filter isPrime
                            |> Seq.sum


sumPrimesUpTo 2000000