using System;

class Arithmetic
{
    static void Main()
    {

        int number1; //declare first number to add
        int number2; //declare second number to add
        int sum; // declare sum of number1 an dnumber2
        int product; //declare product of number1 and number2
        int difference; // declare difference of number1 and number2
        int quotent; // declare quotent of number1 and number2


        Console.Write("Enter the first integer:"); // prompt user

        number1 = int.Parse(Console.ReadLine()); // read first number from user

        Console.Write("Enter the second integer:"); // prompt user

        number2 = int.Parse(Console.ReadLine());// read second number from user

        sum = number1 + number2; // add numbers
        product = number1 * number2; // multiply numbers
        difference = number1 - number2; //subtract numbers
        quotent = number1 / number2; //divide numbers


        Console.WriteLine($"Sum is {sum}"); //display sum 
        Console.WriteLine($"Product is {product}");
        Console.WriteLine($"Difference is {difference}");
        Console.WriteLine($"Quotent is {quotent}");

        Console.ReadLine(); // Keeps the console window open until Enter is pressed
    } // end main
} // end class arithmetic
