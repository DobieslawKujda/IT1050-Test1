using System;

class MainClass {
  public static void Main (string[] args) {

    //declaring variables
    string itm1;
    string itm2;
    string itm3;

    int itm1_qnty;
    int itm2_qnty;
    int itm3_qnty;

    double itm1_prc;
    double itm2_prc;
    double itm3_prc;

    double total_prc;


    Console.WriteLine("Enter the name of 'ITEM 1': ");
    itm1 = Console.ReadLine();

    Console.WriteLine("Set the price of one "+ itm1 + " :");
    itm1_prc = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the quantity of " + itm1 + "(s) :");
    itm1_qnty = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the name of 'ITEM 2': ");
    itm2 = Console.ReadLine();

    Console.WriteLine("Set the price of one "+ itm2 + " :");
    itm2_prc = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the quantity of " + itm2 + "(s) :");
    itm2_qnty = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter the name of 'ITEM 3': ");
    itm3 = Console.ReadLine();

    Console.WriteLine("Set the price of one "+ itm3 + " :");
    itm3_prc = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the quantity of " + itm3 + "(s) :");
    itm3_qnty = Convert.ToInt32(Console.ReadLine());


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
