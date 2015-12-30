//Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
//How many such routes are there through a 20×20 grid?

//19
//1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1 1

//damn it..
let rec factorial(n:bigint) = if n <= 1I then 1I else n * factorial(n-1I)
let combo n k = factorial(n) / (factorial(k) * factorial(n-k))
let answer = combo 40I 20I