//A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. 
//If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:
//
//012   021   102   120   201   210
//
//What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?


//get list of permutations
//list them alphabetically
//get 1000000th lexicographic permutation


let putIntoPosition ((list:string), (el:string), (index:int)) = list.[0.. index-1] + el +  list.[index.. list.Length-1]

let generateList ((currentList:string), (element:string)): string list = (currentList+ element) ::(currentList.ToCharArray() |> Array.mapi(fun i x-> putIntoPosition(currentList, element.ToString(), i)) |> Array.toList)
                                                         
let rec getPermutations ((arrayOfPermutations:string list), number) : string list= 
        match number with
        | 10    -> arrayOfPermutations
        | x     -> let newPermutations = arrayOfPermutations |> List.fold(fun acc x -> (generateList(x, number.ToString()) @ acc)) []
                   getPermutations (newPermutations, (number + 1))

getPermutations (["0"], 1) |> List.sort |> List.toSeq |> Seq.skip 999999 |> Seq.take 1
