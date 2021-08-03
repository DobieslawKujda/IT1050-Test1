using System;
using System.Globalization;
using System.Collections.Generic;

public class books{

  public string isbn {get; set;}
  public string title {get; set;}
  public string authi {get; set;}
  public string publish {get; set;}

  public virtual DateTime published {get; set;}
}

public class book  {

  public string _ISBN {get; set;}
  public string _TITLE {get; set;}
  public string _authori {get; set;}
  public string _publisher {get; set;}

  public virtual DateTime _publishdate {get; set;}

  public void books(string ISBN, string TITLE, string authori){
    _ISBN = ISBN;
    _TITLE = TITLE;
    _authori = authori;
  }

  public void books(string publisher, DateTime publishdate){

    publishdate = DateTime.Today;
    publisher = "unknown";

    if(_publishdate == null){
      _publishdate = publishdate;
    }
    if(_publisher == null){
      _publisher = publisher;
    }

  }

  public void displayinfo(){
    Console.WriteLine("Book '" + _TITLE + "' written by: " + _authori + ". \npublished by: '" + _publisher + "' on " + _publishdate + ".");
  }
}
