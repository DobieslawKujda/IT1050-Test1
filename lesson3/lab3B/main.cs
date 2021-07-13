using System;

class MainClass {
  public static void Main (string[] args) {
    //variables

    string name;
    string saleamount;

    int sale;
    double cut;

    Console.WriteLine ("This is an program to calculate commision based on salesamount.");

    Console.WriteLine("Enter the salesperson's name: ");
    name = Console.ReadLine();

    Console.WriteLine("Enter the amount of the sale: ");
    saleamount = Console.ReadLine();

    sale = Convert.ToInt32(saleamount);

    cut = (200 + (0.09*sale));

        //I decided to make the sales person's performance and their commission be a single output.
        
        if (sale<2999){
          Console.WriteLine("The commission for " + name + " is: "+ cut + " meaning that " + name + " has poor performance.");
        }else if(sale > 3000 && sale < 4999){
          Console.WriteLine("The commission for " + name + " is: "+ cut + " meaning that " + name + " has average performance.");
        }else if(sale > 5000 && sale < 9999){
          Console.WriteLine("The commission for " + name + " is: "+ cut + " meaning that " + name + " has good performance.");
        }else if(sale > 10000 && sale < 14999){
          Console.WriteLine("The commission for " + name + " is: "+ cut + " meaning that " + name + " has excellent performance.");
        }else{
          Console.WriteLine("The commission for " + name + " is: "+ cut + " meaning that " + name + " has outstanding performance.");
        }
  }
}
