using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello, this is my book rental console app for IT1050. ENJOY! ");

    Patron p = new Patron();
    p._fname = "john";
    p._lname = "peter";
    p._id = "0001";

    Patron p1 = new Patron("seth", "j", "0002");
    Patron p2 = new Patron("beth", "s", "0003");
    Patron p3 = new Patron("neth", "p", "0004");
    Patron p4 = new Patron("reth", "k", "0005");

    p.display();
    p1.display();
    p2.display();
    p3.display();
    p4.display();


    Rental r = new Rental();

    object book0 = "book 1 of a 5 book series";
    object book1 = "book 2 of a 5 book series";
    object book2 = "book 3 of a 5 book series";
    object book3 = "book 4 of a 5 book series";
    object book4 = "book 5 of a 5 book series";

    DateTime thisday = DateTime.Today;

    r.firstname = "John";
    r.lastname = "Peter";
    r.addToRentalCart(book0, thisday);
    Console.WriteLine("");
    r.removeFromRentalCart(book2);

    

  }
}
