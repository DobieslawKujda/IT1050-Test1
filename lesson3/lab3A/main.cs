using System;

class MainClass {
  public static void Main (string[] args) {
    
    //adding variables at the top of the code
    string input;

    double tmp_f;
    double tmp_c;
    
    //actual code
    Console.WriteLine ("This is my Celsius to Fahrenheit conversion tool!");
    Console.WriteLine("Please enter the temperature in Celsius: ");

    input = Console.ReadLine();

    tmp_c = Convert.ToDouble(input);

    tmp_f = ((tmp_c * 1.8) + 32);
    
    Console.WriteLine(tmp_f + " degrees fahrenheit.");
    
    //for sake of optimization I'd want to replace this with a switch statement rather than a
    //'if-else' argument. but meh, for only 3 conditions that run once this is fine.
    if(tmp_f < 32){
        Console.WriteLine("The temperature is below the freezing point of 32 degrees fahrenheit.");
    }else if(tmp_f > 212){
        Console.WriteLine("The temperature is above the boiling point of 212 degrees fahrenheit.");
    }else{
        Console.WriteLine("The temperature is above is between 32 and 212 degrees fahrenheit.");
    }
    
    Console.WriteLine("Complete.");
  }
}
