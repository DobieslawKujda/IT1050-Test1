using System;

class employee{

  private static string firstname;
  private static string lastname;
  private static string id;
  private static string address;
  private static long phonenumber;
  private static string title;
  private static string employmentstatus;

  private static int age;
  private static string yrlyslry;

  public static void employe(){
    firstname = "unknown";
    lastname = "unknown";
    id = "unknown";
    phonenumber = 0000000000;
    title = "new Employee";
    age = 0;
    employmentstatus = "active";
    yrlyslry = "50000 usd";
    address = "N/A";

  }

  public static void Intro(){

    Console.WriteLine("Blank Employee Template: ");
    Console.WriteLine("Firstname: " + firstname);
    Console.WriteLine("Lastname: " + lastname);
    Console.WriteLine("Employee age: " + age);
    Console.WriteLine("Phone Number: " + phonenumber);
    Console.WriteLine("Employee Address: " + address);
    Console.WriteLine("Employee ID: " + id);
    Console.WriteLine("Title: " + title);
    Console.WriteLine("Yearly Salary: " + yrlyslry);
    Console.WriteLine("Employment status: " + employmentstatus);

  }

  public static void newemply(){
    string[] inputs = new string[8];
    string[] inpts = new string[] {"firstname", "lastname", "age", "phonenumber", "address", "id", "title", "yearly salary"};
    int i = 0;
    int e = 0;
    
    foreach(string p in inputs){
      Console.WriteLine("\tplease enter the " + inpts[i] + " for the new employee : ", p);
      inputs[i] = Console.ReadLine();

      i++;
    }
    foreach(string o in inputs){
      Console.WriteLine(inpts[e] + ": " + inputs[e]);

      e++;
    }
  }

  public static void emply(string firstname, string lastname, int age, long phonenumber, string address, string id, string title, string yrlyslry){
    Console.WriteLine("Firstname: " + firstname);
    Console.WriteLine("Lastname: " + lastname);
    Console.WriteLine("Employee age: " + age);
    Console.WriteLine("Phone Number: " + phonenumber);
    Console.WriteLine("Employee Address: " + address);
    Console.WriteLine("Employee ID: " + id);
    Console.WriteLine("Title: " + title);
    Console.WriteLine("Yearly Salary: " + yrlyslry);
    Console.WriteLine("Employment status: " + employmentstatus);
  }
}
