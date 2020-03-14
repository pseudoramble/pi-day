# Happy Pi Day!

Pi is a number with a few decimal places. Infinite, in fact. The first few digits are 3.14.

Pi Day is on March 14th each year, AKA 03-14. Get it? Hah!

Here are some ways to do the Pi.

## 2020 - Chudnovsky algorithm

[The code](https://github.com/pseudoramble/pi-day/blob/master/2020-chudnovsky.fs).

This takes the form:

    π ≈ (426880 * sqrt(10005)) / (13591409a + 545140134b)
    a = ∑ a_k
    a_k = -((24 * (6k - 5)(2k - 1)(6k - 1)) / (k^3)(640320^3)
    b = ∑ (a_k * k)

This particular math makes essentially no sense to me. I don't understand the constants, or why they work. This is more interesting to me because of how quickly it works. For reference, this implementation punched out about 100,000 digits in about 10 seconds, and 1 million digits took about 18 minutes on my machine. Nilakantha took significantly longer to calculate a small fraction of the same digits.

Here's the value it got for 1000 digits: `3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657595919530921861173819326117931051185480744623799627495673518857527248912279381830119491298336733624406566430860213949463952247371907021798609437027705392171762931767523846748184676694051320005681271452635608277857713427577896091736371787214684409012249534301465495853710507922796892589235420199561121290219608640344181598136297747713099605187072113499999983729780499510597317328160963185950244594553469083026425223082533446850352619311881710100031378387528865875332083814206171776691473035982534904287554687311595628638823537875937519577818577805321712268066130019278766111959092164195740`. It looks like the last four digits are off, but is otherwise accurate. This took less than one second to come up with.

## 2019 - Nilakantha series

[The code](https://github.com/pseudoramble/pi-day/blob/master/2019-nilakantha.fs).

This takes the form:

    π ≈ 3 + 4 / (2*3*4) - 4 / (4*5*6) + 4 / (6*7*8) - 4 / (8*9*10) ...

or:

    π ≈ 3 + ∑ 4 / (n*n+1*n+2), n = 2 and goes to infinity

The implementation I did is particularly slow at larger values, partially at least because it generates and holds in memory the actual full sequence of steps instead of dropping each value. But it's good enough for a before bed game.

Here's the value it got for `System.Int32.MaxValue` steps (a little over 2.1 billion): `3.1415926535897932384626432850M`. The first 27 digits after the decimal are correct.