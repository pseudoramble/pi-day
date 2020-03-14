// This code is effectively a line-by-line port of the code found here:
// https://www.craig-wood.com/nick/articles/pi-chudnovsky/
// Thank you, Craig Wood, the mystery person who guided me through!
module Chudnovsky

let bigpown (x: bigint) n = System.Numerics.BigInteger.Pow(x, n)

let bigsqrt (n: bigint) digits =
  let big2 = bigint 2
  let big10 = bigint 10
  let ONE = bigpown big10 digits
  
  let precision = bigpown big10 16
  let nF = double ((n * precision) / ONE) / double precision
  let nOne = n * ONE
  let mutable x = (bigint (double precision * sqrt nF)) * ONE / precision
  let mutable xPrev = System.Numerics.BigInteger.Zero
  while x <> xPrev do
    xPrev <- x
    x <- (x + nOne / x) / big2
  x

let doPi digits =
  let big0 = bigint 0
  let big1 = bigint 1
  let big2 = bigint 2
  let big5 = bigint 5
  let big6 = bigint 6
  let big10 = bigint 10
  let big24 = bigint 24
  let ONE = bigpown big10 digits

  let mutable aK = ONE
  let mutable aSum = ONE
  let mutable bSum = big0
  let mutable kB = big1
  let c = (bigpown (bigint 640320) 3) / big24

  while aK <> big0 do
    aK <- aK * -((big6*kB - big5) * (big2*kB - big1) * (big6*kB - big1))
    aK <- aK / (bigpown kB 3 * c)
    aSum <- aSum + aK
    bSum <- bSum + (kB * aK)
    kB <- kB + big1

  let sum = (bigint 13591409 * aSum) + (bigint 545140134 * bSum)
  let sqrtFactor = bigsqrt ((bigint 10005) * ONE) digits
  let result = (bigint 426880 * sqrtFactor * ONE) / sum
  result

let run digits = 
  doPi digits