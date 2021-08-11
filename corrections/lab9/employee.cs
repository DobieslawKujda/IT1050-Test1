using System;

class employee{

  private string firstname;
  private string lastname;
  private string id;
  private string address;
  private long phonenumber;
  private string title;
  private string employmentstatus;

  private int age;
  private string yrlyslry;

  public void employe(){

    employee e = new employee();

    e.firstname = "unknown";
    e.lastname = "unknown";
    e.id = "unknown";
    e.phonenumber = 0000000000;
    e.title = "new Employee";
    e.age = 0;
    e.employmentstatus = "active";
    e.yrlyslry = "50000 usd";
    e.address = "N/A";

  }

  public void Intro(){

    Console.WriteLine("Blank Employee Template: ");
    Console.WriteLine("Firstname: " + firstname);
    Console.WriteLine("Lastname: " + lastname);
    Console.WriteLine("Employee age: " + age);
    Console.WriteLine("Phone Number: " + phonenumber);
    Console.WriteLine("Employee Address: " + address);
    Console.WriteLine("Employee ID: " + id);
    Console.WriteLine("Title: " + title);
    Console.WriteLine("Yearly Salary: " + yrlyslry);
    employmentstatus = "active";
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
    employee e = new employee();

    Console.WriteLine("Firstname: " + firstname);
    Console.WriteLine("Lastname: " + lastname);
    Console.WriteLine("Employee age: " + age);
    Console.WriteLine("Phone Number: " + phonenumber);
    Console.WriteLine("Employee Address: " + address);
    Console.WriteLine("Employee ID: " + id);
    Console.WriteLine("Title: " + title);
    Console.WriteLine("Yearly Salary: " + yrlyslry);
    e.employmentstatus = "active";
    Console.WriteLine("Employment status: " + e.employmentstatus);
  }
}
