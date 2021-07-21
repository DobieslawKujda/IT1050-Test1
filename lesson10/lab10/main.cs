using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("lesson 10 lab10");
    Console.WriteLine("");
    
    subclass.employe();
    subclass.Intro();
    Console.WriteLine("");

    subclass.emply("Robert", "Downey", 12, "12321", "100");
    subclass.employe();
    Console.WriteLine("");

    subclass.emply("John", "Smith", 38, "S0089", "50000");
    subclass.IncreaseSalary();
    subclass.removeemployee();
    subclass.employe();
    Console.WriteLine("");


    subclass.emply("Maria", "Lambert", 26, "S0010", "80000");
    subclass.IncreaseSalary();
    subclass.removeemployee();
    subclass.removeemployee();
    subclass.employe();
    Console.WriteLine("");

    Console.WriteLine("...");
  }
}
