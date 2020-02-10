using System;

namespace CupsOfCoffee
{
  public class Logic
  {
    public static void Run()
    {
      // Create a variable (use your best judgment for type) that stores the numberOfCupsOfCoffee that you drink every day
      var numberOfCupsOfCoffee = 1;
      // Create a variable (use your best judgment for type) called fullName and set it equal to your full name.
      var fullName = "Austin Parvin";
      // Use the type DateTime to represent today.
      // Create a variable (use your best judgment for type) call today and set it equal to today's date.
      DateTime today = DateTime.Today;

      // using your variables, numberOfCupsOfCoffee, fullNameand today, Console.WriteLine out all three on one line.
      Console.WriteLine("{0} {1} {2}", numberOfCupsOfCoffee, fullName, today.ToString("D"));

      // Ask the user for their name and store it in a variable called 'user'.
      Console.WriteLine("What is your name?");
      var user = Console.ReadLine();

      // Print out a greeting to the user, using their name
      // Some logic to your program that prints our a special message for a user with the of Alice
      if (user == "Alice")
        Console.WriteLine("Follow me down the rabbit hole, {0}", user);
      else
        Console.WriteLine("Welcome, {0}", user);

      // Ask the user to input two numbers
      // Get the numbers as Strings using Console.ReadLine
      // Convert a String to a double using double.parse. Save the first double value in an operand1 variable and the second double value in an operand2 variable
      Console.WriteLine("Give me a number");
      var operand1 = Double.Parse(Console.ReadLine());
      Console.WriteLine("Give me another number");
      var operand2 = Double.Parse(Console.ReadLine());

      // Add the operands and save in a sum variable
      var sum = operand1 + operand2;
      // Subtract the operands and save in a difference variable
      var difference = operand1 - operand2;
      // Divide the operands and save in a quotient variable
      var quotient = operand1 / operand2;
      // Multiply the operands and save in a product variable
      var product = operand1 * operand2;
      // Find the remainder when one operand is divided by the other and save in a remainder variable. See this page if you need to learn more about the modulo operator.
      var remainder = operand1 % operand2;

      // print all the results to the screen in a meaningful way.
      Console.WriteLine("The Sum of {0} and {1} is: {2}", operand1, operand2, sum);
      Console.WriteLine("The Difference of {0} and {1} is: {2}", operand1, operand2, difference);
      Console.WriteLine("The Quotient of {0} and {1} is: {2}", operand1, operand2, quotient);
      Console.WriteLine("The Product of {0} and {1} is: {2}", operand1, operand2, product);
      Console.WriteLine("The Remainder of {0} and {1} is: {2}", operand1, operand2, remainder);
    




    }
  }
}
