using System;

public class Person{

  public string _fname { get; set; }
  public string _lname { get; set; }
  public string _id { get; set; }

  public Person(){
    Console.WriteLine("...");
  }

  public Person(string fname, string lname, string id){
    _fname = fname;
    _lname = lname;
    _id = id;
  }      
}
