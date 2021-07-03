using System;
using System.Linq;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("loops stuff 10 times then sorts into evens and odds app.");

    double[] numbers = new double[10];

    int ev = 0;
    int ov = 0;
    
    double[] oddnum = new double[5];
    double[] evennum = new double[5];

    string input;

    int cnt = 1;
    int i = 0;
    double num;

    while(cnt <= 10){

      Console.WriteLine("Please enter a number: ");

      input = Console.ReadLine();

      num = Convert.ToDouble(input);

      numbers[i] = num;
      i++;
      cnt++;
    }

    foreach(double nmbr in numbers){
      if(nmbr%2 == 0){
        evennum[ev] = nmbr;
        ev++;
      }else{
        oddnum[ov] = nmbr;
        ov++;
      }

    }

    Array.Sort(oddnum);
    Array.Sort(evennum);
    Array.Reverse(oddnum);

    Console.WriteLine("Here are the odd numbers in descending order: ");

    foreach(double nmbr in oddnum){
      Console.WriteLine(nmbr);
    }

    Console.WriteLine("The sum of the odd numbers is: " + oddnum.Sum());

    Console.WriteLine("Here are the even numbers in ascending order: ");

    foreach(double nmbr in evennum){
      Console.WriteLine(nmbr);
    }
    Console.WriteLine("The sum of the even numbers is: " + evennum.Sum());
  }
}
