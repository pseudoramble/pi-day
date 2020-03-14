module Nilakanatha

let term n =
  let nF = decimal n;
  let step = 
    if n < 1
    then 0.0m
    else 4.0m / ((nF * 2.0m)*(nF * 2.0m + 1.0m)*(nF * 2.0m + 2.0m))
  if n % 2 = 0 then -step else step

let doPi n = 
  Seq.initInfinite term
  |> Seq.take n
  |> Seq.sum

let run iterations = 
  3.0m + (doPi iterations)