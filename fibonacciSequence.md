#...algorithm to find the Fibonacci sequence...#
This algorithm will compute the first n numbers of the fibonacci sequence because the fibonacci sequence is infinite

0. start
1. declare variable inputNumber of type uint (this takes in only positive number);
2. initialise inputNumber (input from user)
3. check if number is of the correct data type. if input is not of the required data type, print invalid input to user
4. declare variable fibonacci of type integer array of length equal to the inputNumber
5. initialise the first element of the array with the value 0 and the second element of the array with value 1;
6. if inputNumber is 1; print the value in the first index (index 0) of the fibonacci array;
7. if inputNumber is 2; print the values in the first (0) and second index (1) of the fibonacci array;
8. if inputNumber is freater than 2;
    8.1 from the index 3 to index (inputNumber - 1), set the value at each index to be the sum of the values of the two preceeding index;
9. print the values in the fibonacci array from index 0 to index (inputnumber - 1);
10. stop