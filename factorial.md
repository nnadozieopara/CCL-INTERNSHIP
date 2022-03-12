#...algorithm to find the factorial of a number...#

0. Start
1. declare variable inputNumber of type uint (this takes only posotive intergers);
2. initialise variable inputNumber (with input from user);
3. check if inputNumber is of type uint. If not, print invalid number to the user;
4. declare variable factorial of type uint; to hold the result of the factorial of the input number;
5. initialise factorial a value of 1.
5. if inputNumber is zero(0) or one(1), print factorial;
6. if number is greater than 1, run a loop.
7. while inputNumber is greater than 1;
    7.1. multiply factorial by inputNumber
    7.2. reduce inputNum by 1
8. print factorial
9. stop