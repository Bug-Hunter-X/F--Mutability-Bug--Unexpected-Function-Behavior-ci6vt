let mutable x = 10
let mutable y = 20

let add x y = x + y

let result = add x y
printfn "%d" result

x <- 15
y <-25

let result2 = add x y
printfn "%d" result2