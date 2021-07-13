using System;
using System.Linq;
using System.Collections.Generic;

class MainClass {
  public static void Main(string[] args)
        {
            Console.WriteLine("This app calculates and displays parking charges for a specified amount of customers: ");

            //variables
            List<string> cstmrs = new List<string>();
            List<double> hours = new List<double>();

            string usrinpt;

            double pricettl = 0;
            double prc;

            bool loopy = true;

            cstmrs.Add("customer 1");
            cstmrs.Add("customer 2");
            cstmrs.Add("customer 3");

            hours.Add(2);
            hours.Add(1);
            hours.Add(3);

            //ask if there are any new  customers:
            while(loopy){
              Console.WriteLine("Are there any new customers on the lot? (Y/N)");

              usrinpt = Console.ReadLine();

              if (usrinpt == "N")
              {
                //int ttlhrs = hours.Sum(x => Convert.ToInt32(x));
                //Console.WriteLine(ttlhrs);
                //parking charges are min 2$ for 3 hours then .5$ for each additional hours
                //maximum parking time is 24 hours total of 12.5$

                loopy = false;

                foreach(int x in hours){
                  if(x >= 24){
                    pricettl += 10;
                  }else if(x > 3){
                    prc = ((x - 3)*0.5)+2.00;
                    pricettl += prc;
                  }else{
                    pricettl++;
                    pricettl++;
                  }
                }

              Console.WriteLine("The sale total for the day is: $" + pricettl);

              }else if(usrinpt ==  "Y"){
              Console.WriteLine("Enter the customer's name: ");
              usrinpt = Console.ReadLine();
              cstmrs.Add(usrinpt);

              Console.WriteLine("Enter the number of hours " + usrinpt + " parked for:");
              usrinpt = Console.ReadLine();

              hours.Add(Convert.ToInt32(usrinpt));
              }
            }
        }
}
