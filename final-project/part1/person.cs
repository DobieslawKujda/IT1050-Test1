using System;

public class Person{

  public string _fname { get; set; }
  public string _lname { get; set; }
  public string _email { get; set; }

  public Person(){
    Console.WriteLine("...");
  }

  public Person(string fname, string lname, string email){
    _fname = fname;
    _lname = lname;
    _email = email;
  }      
}
