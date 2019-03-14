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

The implementation I did is particular slow at larger values, partially at least because it generates the actual full sequence of steps instead of losing that information each step. But it's good enough for a before bed game.