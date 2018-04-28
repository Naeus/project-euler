let sumFormula n:int =
    n * (n + 1) / 2

let sumMultiples m n =
    let quantityOfNumbers = int(ceil(float(n) / float(m))) - 1
    int(m * (sumFormula quantityOfNumbers))

let sumTwoRelativelyPrimeMultiples m1 m2 n =
    sumMultiples m1 n + sumMultiples m2 n - sumMultiples (m1 * m2) n

// Use the EntryPoint attribute to run the program.
[<EntryPoint>]
let main args =
    Printf.printfn "Sum of multiples of 3 and 5 less than 1000 is: %i" (sumTwoRelativelyPrimeMultiples 3 5 1000)
    0