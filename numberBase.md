#...algorithm to convert a given number from one base to another...#
This algorithm converts integer numbers from one base to another.

0. start
1. declare variable inputNumber of type integer
2. declare a varible currentBase of type integer;
3. declare a variable nextBase of type integer;
4. declare a variable isNegative of type boolean and assign a value of false to it.
5. initialise variable inputNumber (value entered by the user);
6. if inputNumber is negative, multiply inputNumber by -1 and update isNegative to true;
7. check if inputNumber is valid in the given currentBase. if inputNumber is npt valid, print "invalid number" to the user.
8. declare a variable digits of type integer to hold the number of digits of inputNumber;
9. get the number of digits in the inputNumber and assign it to the variable digits
10. declare a variable converted of type integer and initialise it to have a value of zero;
11. if nextBase is 10, multiply each digit of inputNumber by 10 raised to a power. The power begins from zero to 1 less than the value of the variable digits.
12. the first digit from the right has the power of zero, the second digit a power of one and the power increases till we get to the last number from the right which takes the power of digits minus 1;
13. assign the variable converted the sum of the multiplication of the digits of inputNumber by ten raised to their respective power
14. print converted.
15. if nextBase is not ten, convert inputNumber first to base 10 and store in a variable intermediateBase of type integer;
16. convert intermediateBase to nextBase.
        to convert from base 10 to other base,
        1. declare a variable to type string and initialise it with a value of "empty string". call it newBase.
        2. while inputNumber is greater than zero, divide inputNum by nextBase and add the remainder to the variable newBase, and inputNumber become the quotient of the division.
        3. print newBase;
17. update converted to have the value of newBase
18. if the booolean variable isNegative is true, multiply converted by -1;
19. print out converted.
20. stop
