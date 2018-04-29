let fibonacci n =
    let m = float n
    int((((1.0 + (sqrt 5.0)) ** m) - ((1.0 - (sqrt 5.0)) ** m)) / ((2.0 ** m) * (sqrt 5.0)))


let quantityOfFibonacciTermsLessThan n =
    let phi = 0.5 * (1.0 + (sqrt 5.0))
    int(round (((log (float(n) + 0.5)) + (0.5 * (log 5.0))) / (log phi)))
    

let sumEvenFibonacciLessThan n =
    let theLastTerm = quantityOfFibonacciTermsLessThan n
    let theLastEvenTerm = theLastTerm - (theLastTerm % 3)
    int(((fibonacci (theLastEvenTerm + 2)) - (fibonacci 2)) / 2)


[<EntryPoint>]
let main argv =

    let n = int(4.0 * (10.0 ** 6.0))
    printfn "Sum of even Fibonacci numbers less than %i is equal to: %i" n (sumEvenFibonacciLessThan n)

    0 // return an integer exit code