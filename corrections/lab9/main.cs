using System;
class MainClass {
  public static void Main (string[] args) {

    string inpt;
    bool loopy = true;

    Console.WriteLine ("Employee App");

    employee e = new employee();

    e.employe();
    Console.WriteLine("");
    e.Intro();
    Console.WriteLine("");
    employee.emply("John", "Smith", 45, 5155559999, "555 somethingstreet, cleveland, ohio", "1234", "VP-Sales", "10 dollars and a cup of coffee");


    while(loopy){
      Console.WriteLine("");
      Console.Write("New Employee? (Y/N)_ ");
      inpt = Console.ReadLine();
      
      if(inpt == "Y"){
        employee.newemply();
      }else{
        loopy = false;
      }
    }
  }
}
