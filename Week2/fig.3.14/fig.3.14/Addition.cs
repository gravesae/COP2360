// Fig. 3.14: Addition.cs
// Displaying the sum of two numbers input from the keyboard
using System;


 public class Addition
 {
    static void Main(string[] args)
   {
     int number1; //declare the first number to add
     int number2; //declare the second number to add
     int sum; // declare the sum of number1 and number2

     Console.Write("Enter first integer: "); //prompt user
     //read first number from user
     number1 = Convert.ToInt32(Console.ReadLine());

     Console.Write("Enter second integer: "); //prompt user
      //read second number from user
     number2 = Convert.ToInt32(Console.ReadLine());

     sum = number1 + number2;

     Console.WriteLine("Sum is {0}", sum); //display sum
   } //end main
 } // end class Addition

