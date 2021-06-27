using System;

class MainClass {
  public static void Main (string[] args) {
    
    int num;
    int result;
    int cool;

    int notifier = 0;

    Console.WriteLine ("Is this number a prime or not a prime?");

      string userinput = Console.ReadLine();

        num = Convert.ToInt32(userinput);

        result = (num / 2);

        for(cool = 2; cool <= result; cool++){
          if((num % cool) == 0){
            Console.WriteLine(num + " is not prime.");

            notifier = 1;

            break;
          }
        }

        if(notifier == 0){
          Console.WriteLine(num + " is a prime.");
        }
    
  }
}
