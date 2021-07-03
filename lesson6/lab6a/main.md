using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("7 day average temperature for a city application: ");

    //variables made at the top because it helps keep the code organized

    double[] celsius = new double[7];
    double[] fahrenheit = new double[7];

    int a = 1;
    int i = 0;

    string input;
    double avgtmpf;

    foreach(double day in celsius){

      Console.WriteLine("Enter the temperature for day " + a + ":");

      input = Console.ReadLine();

      celsius[i] = Convert.ToDouble(input);

      fahrenheit[i] = ((celsius[i] * (9/5)) + 32);

      a++;
      i++;
    }

    Array.Sort(fahrenheit);
    Array.Reverse(fahrenheit);

    avgtmpf = fahrenheit.Average();

    Console.WriteLine("Here are the temperatures in fahrenheit from highest to lowest: ");

    foreach(double temp in fahrenheit){

      Console.WriteLine(temp + "");
    }

    Console.WriteLine("Here is the average temperature in fahrenheit: " + avgtmpf + " ");
  }
}
