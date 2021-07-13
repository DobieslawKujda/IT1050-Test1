using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("This is my INTEGER POWER APP THAT RETURNS THE PRODUCT!");

    int x;
    int pwr;
    int prdct = 1;

    string usrinpt;

    Console.WriteLine("Enter a base number: ");

    usrinpt = Console.ReadLine();

    x = Convert.ToInt32(usrinpt);

    Console.WriteLine("Enter a power number: ");

    usrinpt = Console.ReadLine();

    pwr = Convert.ToInt32(usrinpt);

    if(pwr > 0){
      for(int i = 1; i <= pwr; ++i){
        prdct *= x;
      }
    }else if(pwr < 0){
      for(int i = -1; i >= pwr; --i){
        prdct /= x;
      }
    }

    Console.WriteLine(prdct);
  }
}
