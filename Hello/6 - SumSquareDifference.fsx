//The sum of the squares of the first ten natural numbers is,
//
//1^2 + 2^2 + ... + 10^2 = 385
//The square of the sum of the first ten natural numbers is,
//
//(1 + 2 + ... + 10)2 = 552 = 3025
//Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
//
//Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

let numbers = {1.0.. 100.0}

let sumOfSquares = numbers |> Seq.fold(fun res x -> res + float x ** 2.0) 0.0

let squareOfSum = (numbers |> Seq.fold(fun res x -> res + float x) 0.0) ** 2.0


let result = squareOfSum - sumOfSquares
printfn "%f" result 