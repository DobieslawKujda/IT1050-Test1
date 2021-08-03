using System;
using System.Collections.Generic;

public class author : Person{

  private List<books> book = new List<books>();

  private List<author> authorinfo = new List<author>();

  public author() : base(){

  }
  
  public author(string fname, string lname, string email) : base(fname, lname, email){

    
  }

  public void displayinfo(){
    Console.WriteLine("Author: " +  _fname + " "+ _lname + " .");  
    if(_email == "n/a"){
      Console.WriteLine("This author does not have an email.");
    }else{
      Console.WriteLine("The author's email is: " + _email);
    }
  }

  public void displaybooks(){
    
  }

  public void addbook(){

    


  }

  public void removebook(){

  }
}
