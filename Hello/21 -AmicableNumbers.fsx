//Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
//If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
//
//For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
//
//Evaluate the sum of all the amicable numbers under 10000.

// rasti visus amicable numbers mazesnius uz 10000
// parasyt fja kuri paimtu skaiciu ir pamegintu rasti amicable atitikmeni

let numbers = seq {1.. 10000}


// grazina skaiciaus dalmenis
let divisors number = seq{1.. number/2} |> Seq.map(fun x -> if (number%x = 0) then x else 0) |> Seq.filter(fun x -> x<>0)
let d number = (divisors number) |> Seq.sum

let isAmicable number = let sumOfDivisors = d number
                        let sumOfDivisors2 = d sumOfDivisors
                        if (number = sumOfDivisors2 && number <> sumOfDivisors) then number else 0


let result = numbers |> Seq.map(fun x -> isAmicable x) |> Seq.filter(fun x -> x <>0) |> Seq.sum