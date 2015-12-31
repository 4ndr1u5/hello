//Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
//
//For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
//
//What is the total of all the name scores in the file?

open System.IO

let filePath = @"C:\Training\euler\hello\Hello\p022_names.txt";

let readLines (filePath:string) = 
    use sr = new StreamReader (filePath)
    sr.ReadLine ()

let score (name:string) = name.ToCharArray() |> Array.map(fun x -> int x - 64) |> Array.sum

let parseStringIntoSeq (str:string) = str.Replace("\"", "").Split(',') |> Seq.ofArray 
//let finalScoreSingle names (name:string) = names |> Seq.sort |> Seq.mapi(fun i x-> ((i+1) * score x, x)) |> Seq.filter(fun (x,y) -> y=name)
let finalScore names = names |> Seq.sort |> Seq.mapi(fun i x-> (i+1) * score x) |> Seq.sum

let result = filePath |> readLines |> parseStringIntoSeq |> finalScore


let actualNames = readLines filePath

//finalScoreSingle (parseStringIntoSeq(readLines(filePath))) "COLIN"