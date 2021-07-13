using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    
    //variables

    double distance;
    double time;
    double speed;

    int i;
    int a = 0;
    
    string userinput;

    Console.WriteLine ("Application to calculate the speed of cars in a race.");
    Console.WriteLine("How many cars are in the race? Enter below:");
    userinput = Console.ReadLine();

    i = Convert.ToInt32(userinput);

    string[] cars = new string[i];
    double[] avgspd = new double[i];
    

    foreach(string car in cars){

      Console.WriteLine("");

      Console.WriteLine("Enter the distance traveled for car" + (a + 1) + " in miles: ");
      userinput = Console.ReadLine();

      distance = Convert.ToDouble(userinput);

      Console.WriteLine("Enter the time taken for car" + (a + 1) + " in hours: ");
      userinput = Console.ReadLine();

      time = Convert.ToDouble(userinput);

      speed = (distance / (time));

      avgspd[a] = speed;

      Console.WriteLine("The speed for car" + (a + 1) + " is: " + speed + " mph.");

      a++;
    }
    
    Console.WriteLine("The Average Speed for the " + i + " cars is: ");
    Console.WriteLine(avgspd.Average() + "mph");

  }
}
