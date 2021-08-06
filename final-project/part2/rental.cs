using System;
using System.Collections.Generic;

class Rental{

  public object book;
  public DateTime rentdate;
  public DateTime returndate;

  public string firstname {get; set;}
  public string lastname {get; set;}
  
  public static void rental(){

  }

  Patron p = new Patron();

  public void addToRentalCart(object _book, DateTime _rentdate){

    book = _book;
    rentdate = _rentdate;

    p.rentalcart.Add(book);

    string b = Convert.ToString(book);

    Console.WriteLine("added to rental cart: " + b + " to the cart of: " + firstname + " " + lastname + " .\n on: " + rentdate);
  }
  public void removeFromRentalCart(object _book){

    book = _book;

    p.rentalcart.Remove(book);

    string b = Convert.ToString(book);

    

    Console.WriteLine("removed from rental cart: " + b + " to the cart of: " + firstname + " " + lastname + " .");
  }
}
