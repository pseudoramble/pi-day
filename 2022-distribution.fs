module Distrubtion

let big10 = bigint 10

let rec distAux d (p: bigint) m =
  match d with
  | 0 -> m
  | _ -> 
    let digit = p % big10
    let count = if Map.containsKey digit m then (Map.find digit m) + 1 else 1
    let step = Map.add digit count m

    distAux (d - 1) (p / big10) step

let run (digits: int) (pi: bigint) = 
  distAux digits pi Map.empty