//If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
//Find the sum of all the multiples of 3 or 5 below 1000.

let numbers = seq { 0 .. 1000 }
let filter a numbers = numbers 
                    |> Seq.filter (fun x -> x%a <> 0)

let result = Array.sum (numbers
            |> (filter 3)
            |> (filter 5)
            |> Seq.toArray)
             
printfn "%d" result

