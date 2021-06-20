using System;

class MainClass {
  public static void Main (string[] args) {

    //declaring variables
    string itm1;
    string itm2;
    string itm3;

    int itm1_qnty = new int();
    int itm2_qnty = new int();
    int itm3_qnty = new int();

    double itm1_prc = new double();
    double itm2_prc = new double();
    double itm3_prc = new double();

    double total_prc = new double();


    Console.WriteLine("Enter the name of 'ITEM 1': ");
    itm1 = Console.ReadLine();

    Console.WriteLine("Set the price of one "+ itm1 + " :");
    //using a while loop to prevent userinput that is not numerical
    while(!double.TryParse(Console.ReadLine(), out itm1_prc)){
      Console.WriteLine("Please enter the price with numerical values including decimal places.");
    }

    Console.WriteLine("Enter the quantity of " + itm1 + "(s) :");
    while(!int.TryParse(Console.ReadLine(), out itm1_qnty)){
      Console.WriteLine("Please only enter the amount of " + itm1 + "(s) in numerical values.");
    }

    Console.WriteLine("Enter the name of 'ITEM 2': ");
    itm2 = Console.ReadLine();

    Console.WriteLine("Set the price of one "+ itm2 + " :");
    //using a while loop to prevent userinput that is not numerical
    while(!double.TryParse(Console.ReadLine(), out itm2_prc)){
      Console.WriteLine("Please enter the price with numerical values including decimal places.");
    }

    Console.WriteLine("Enter the quantity of " + itm2 + "(s) :");
    while(!int.TryParse(Console.ReadLine(), out itm2_qnty)){
      Console.WriteLine("Please only enter the amount of " + itm2 + "(s) in numerical values.");
    }

    Console.WriteLine("Enter the name of 'ITEM 3': ");
    itm3 = Console.ReadLine();

    Console.WriteLine("Set the price of one "+ itm3 + " :");
    //using a while loop to prevent userinput that is not numerical
    while(!double.TryParse(Console.ReadLine(), out itm3_prc)){
      Console.WriteLine("Please enter the price with numerical values including decimal places.");
    }

    Console.WriteLine("Enter the quantity of " + itm3 + "(s) :");
    while(!int.TryParse(Console.ReadLine(), out itm3_qnty)){
      Console.WriteLine("Please only enter the amount of " + itm3 + "(s) in numerical values.");
    }


    total_prc = (itm1_prc * itm1_qnty) + (itm2_prc * itm2_qnty) + (itm3_prc * itm3_qnty);


    Console.WriteLine("Receipt:");
    Console.WriteLine(itm1 + "-->   $" + (itm1_prc * itm1_qnty));
    Console.WriteLine(itm2 + "-->   $" + (itm2_prc * itm2_qnty));
    Console.WriteLine(itm3 + "-->   $" + (itm3_prc * itm3_qnty));
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Total:     $" + total_prc);
  }
}
