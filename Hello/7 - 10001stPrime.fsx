//By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
//
//What is the 10 001st prime number?


open System
 
let is_prime x =
    let rec check i =
        x > 1L &&
       (double i > sqrt (double x) || (x % i <> 0L && check (i + 1L)))
    check 2L                
 
let sequence_of_first_n_primes n =
    Seq.initInfinite (fun x -> int64 x)
    |> Seq.filter is_prime
    |> Seq.take n
    |> Seq.max

let result = sequence_of_first_n_primes 10001

printfn "%A" result