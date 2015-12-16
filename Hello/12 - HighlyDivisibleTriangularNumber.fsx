﻿//
//The sequence of triangle numbers is generated by adding the natural numbers. So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:
//
//1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...
//
//Let us list the factors of the first seven triangle numbers:
//
// 1: 1
// 3: 1,3
// 6: 1,2,3,6
//10: 1,2,5,10
//15: 1,3,5,15
//21: 1,3,7,21
//28: 1,2,4,7,14,28
//We can see that 28 is the first triangle number to have over five divisors.
//
//What is the value of the first triangle number to have over five hundred divisors?


//To answer the first question observe that 10 = 2·5, meaning that the number in question has just two prime factors in its decomposition - one with the exponent of α = 1, 
//the other of β = 4: N = p1q4. To make N as small as possible, we have to choose the smallest available primes, 2 and 3. The answer is obviously N = 3124 = 48.

//FIRST GENERATE SEQ OF TRIANGLE NUMBERS

let triangleNumbers = Seq.initInfinite (fun x -> Seq.initInfinite(fun t -> t) |> Seq.take x |> Seq.sum)



let rec factorise n =
    if n = 1 then [] else
    let a = [2 .. n] |> List.find (fun x -> n % x = 0)
    a :: factorise (n / a)

factorise 500

triangleNumbers |> Seq.mapi(fun i x -> factorise x);