//A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
//a^2 + b^2 = c^2
//For example, 32 + 42 = 9 + 16 = 25 = 52.
//There exists exactly one Pythagorean triplet for which a + b + c = 1000.
//Find the product abc.

let triplets n = Seq.init n (fun x -> x+1) 
                 |> Seq.collect(fun x -> Seq.init n (fun y -> (float x, (float y+1.0), (float x ** 2.0 + (float y+1.0) ** 2.0) ** 0.5)))
                 |> Seq.sortBy(fun (a,b,c) -> c)
                 |> Seq.filter(fun (a,b,c) -> c % 1.0 = 0.0)
                 //|> Seq.take(100)
                 |> Seq.sortBy(fun (a,b,c) -> c)

let multiplyTuple(a,b,c) = int a* int b* int c

let result = (triplets 1000)  |> Seq.filter(fun (a,b,c) -> a+b+c=1000.0) |> Seq.nth 1
result |> multiplyTuple

printfn "%A" result
(triplets 100) |> Seq.iter(fun x -> printfn "%A" x)