using System;

class subclass{

  private static string firstname {get; set;}
  private static string lastname {get; set;}
  private static string id {get; set;}
  private static string address;
  private static long phonenumber;
  private static string title;
  private static string employmentstatus {get; set;}

  private static int age;
  private static string yrlyslry;

  public int _age{
    get{
      return age;
    }
    set{
      _age = value; 
    }
  }

  public string _yrlyslry{
    get{
      return yrlyslry;
    }
    set{
      _yrlyslry = value;
    }
  }

  public static void employe(){
    firstname = "unknown";
    lastname = "unknown";
    id = "unknown";
    phonenumber = 0000000000;
    title = "new Employee";
    age = 0;
    employmentstatus = "active";
    yrlyslry = "50000";
    address = "N/A";

  }

  public static void Intro(){

    Console.WriteLine("Blank Employee Templatev (employee 1): ");
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

  public static void IncreaseSalary(){
    string ui;
    
    Console.WriteLine("Enter the salary increase as a percentage: ");
    ui = Console.ReadLine();

    if(Convert.ToInt32(ui) < 0){
      Console.WriteLine("Invalid input! Yearly Salary not updated");
    }else{
      double o = (Convert.ToDouble(ui) / 100);
      double p = Convert.ToDouble(yrlyslry);
      double op = (o * p) + p;
      Console.WriteLine(op);
    }
  }
  
  public static void removeemployee(){
    if(employmentstatus == "inactive"){
      Console.WriteLine("Employee is already inactive.");
    }else{
      employmentstatus = "inactive";
      Console.WriteLine("Employee removed.");
    }
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

  public static void emply(string firstname, string lastname, int age, string id, string yrlyslry){
    Console.WriteLine("Firstname: " + firstname);
    Console.WriteLine("Lastname: " + lastname);

    if(age < 18){
      age = 18;
    }

    Console.WriteLine("Employee age: " + age);
    Console.WriteLine("Employee ID: " + id);

    if(Convert.ToInt32(yrlyslry) < 1000){
      yrlyslry = "1000";
    }
    Console.WriteLine("Yearly Salary: " + yrlyslry);
    Console.WriteLine("Employment status: " + employmentstatus);
  }
}
