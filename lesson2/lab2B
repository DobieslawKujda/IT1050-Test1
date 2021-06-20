using System;

class MainClass {
  public static void Main (string[] args) {

    //declaring variables
    int num1 = new int();
    int num2 = new int(); //num1 and num2 are the integers that hold the values to be added.
    int sum = new int(); //creating sum int for now to be used later.
    


    //start of application.


    Console.WriteLine("Enter a number: " );
    //using a while-loop to prevent an error when the user enters a non-integer value.
    while(!int.TryParse(Console.ReadLine(), out num1)){
      Console.WriteLine("Please only enter an integer.");
    }
    Console.WriteLine("Enter another number: ");
    //using a while-loop to prevent an error when the user enters a non-integer value.
    while(!int.TryParse(Console.ReadLine(), out num2)){
      Console.WriteLine("Please only enter an integer.");
    }

    //adding integers together into sum
    sum = num1 + num2;

    //outputting sum.
    Console.WriteLine("The sum of the numbers is: ");
    Console.WriteLine(sum);

    //the application is complete, having the console say that it is done.
    Console.WriteLine("Run Complete.");
  }
}
