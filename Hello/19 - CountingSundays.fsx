//You are given the following information, but you may prefer to do some research for yourself.
//
//1 Jan 1900 was a Monday.
//Thirty days has September,
//April, June and November.
//All the rest have thirty-one,
//Saving February alone,
//Which has twenty-eight, rain or shine.
//And on leap years, twenty-nine.
//A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
//How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?

//reikia:
// tuple savaites dienu ir datos

let years = seq {1901.. 2000}
let months = seq {1.. 12}

let cartesian xs ys = 
    xs |> Seq.collect (fun x -> ys |> Seq.map (fun y -> x, y))
//let allDays = years|> Seq.map(fun x -> )
let yearMonths = cartesian years months

let getDates y m = let date = System.DateTime (y,m,01)
                   if(date.DayOfWeek = System.DayOfWeek.Sunday) then
                        true
                   else
                        false
                   
let result = yearMonths |> Seq.map(fun (x, y) -> getDates x y) |> Seq.filter(fun x -> x = true) |> Seq.length

