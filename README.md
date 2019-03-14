# Happy Pi Day!

Pi is a number with a few decimal places. Infinite, in fact. The first few digits are 3.14.

Pi Day is on March 14th each year, AKA 03-14. Get it? Hah!

Here are some ways to do the Pi.

## 2019 - Nilakantha series

[The code](https://github.com/pseudoramble/pi-day/blob/master/2019-nilakantha.fsx).

This takes the form:

    π ≈ 3 + 4 / (2*3*4) - 4 / (4*5*6) + 4 / (6*7*8) - 4 / (8*9*10) ...

or:

    π ≈ 3 + ∑ 4 / (n*n+1*n+2), n = 2 and goes to infinity

The implementation I did is particularly slow at larger values, partially at least because it generates and holds in memory the actual full sequence of steps instead of dropping each value. But it's good enough for a before bed game.

Here's the value it got for `System.Int32.MaxValue` steps (a little over 2.1 billion): `3.1415926535897932384626432850M`. The first 27 digits after the decimal are correct.