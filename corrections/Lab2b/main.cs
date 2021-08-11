using System;

class MainClass {
  public static void Main (string[] args) {

    //declaring variables
    int num1;
    int num2;
    int sum;
    


    //start of application.


    Console.WriteLine("Enter a number: " );

    num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter another number: ");

    num2 = Convert.ToInt32(Console.ReadLine());

    //adding integers together into sum
    sum = num1 + num2;

    //outputting sum.
    Console.WriteLine("The sum of the numbers is: ");
    Console.WriteLine(sum);

    //the application is complete, having the console say that it is done.
    Console.WriteLine("Run Complete.");
  }
}
