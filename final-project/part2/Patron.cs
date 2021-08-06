using System;
using System.Collections.Generic;

class Patron : Person{

  public string libraryid {get; set;}
  public virtual DateTime startdate {get; set;}
  public virtual DateTime enddate {get; set;}
  public bool accountactive {get; set;}
  public List<object> rentalcart = new List<object>();
  public int fineamountdue {get; set;}

  public Patron() : base(){

  }
  
  public Patron(string fname, string lname, string id) : base(fname, lname, id){

    string _fname = fname;
    string _lname = lname;
    string _id = id;

    int _fineamountdue = 0;
    DateTime _startdate = DateTime.Today;
    bool _accountactive = true;

    fineamountdue = _fineamountdue;
    startdate = _startdate;
    accountactive = _accountactive;

  }

  public void display(){
    
    Console.WriteLine("Patron ID: " + _id + "\n Name: " + _fname + " " + _lname);

    Console.WriteLine("");

  }
}
