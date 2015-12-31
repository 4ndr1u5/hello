//n! means n × (n − 1) × ... × 3 × 2 × 1
//
//For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
//and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
//
//Find the sum of the digits in the number 100!

let rec factorial(n:bigint) = if n <= 1I then 1I else n * factorial(n-1I)

let number = factorial 100I
let answer = number.ToString().ToCharArray() |> Array.map(fun x-> x.ToString()) |> Array.map int |> Array.sum
