using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
    //variables

    double distance;
    double time;
    double speed;

    int i = 0;
    
    string userinput;

    string[] cars = {"car0", "car1", "car2", "car3", "car4", "car5", "car6"};
    double[] avgspd = new double[7];
    
    Console.WriteLine ("Application to calculate the speed of cars in a race.");

    foreach(string car in cars){

      Console.WriteLine("");

      Console.WriteLine("Enter the distance traveled for " + car + " in miles: ");
      userinput = Console.ReadLine();

      distance = Convert.ToDouble(userinput);

      Console.WriteLine("Enter the time taken for " + car + " in hours: ");
      userinput = Console.ReadLine();

      time = Convert.ToDouble(userinput);

      speed = (distance / (time));

      avgspd[i] = speed;

      Console.WriteLine("The speed for " + car + " is: " + speed + " mph.");

      i++;
    }
    
    Console.WriteLine("The Average Speed for the seven cars is: ");
    Console.WriteLine(avgspd.Average() + "mph");

  }
}
