using System;
using System.Collections.Generic;
using System.Linq;

class MainClass{
    public static void Main(String[] args)
    {

      DateTime tdy = DateTime.Today;

        author a = new author();
        a._fname = "George";
        a._lname = "Orwell";
        a._email = "n/a";
        a.displayinfo();
        
        author a1 = new author("Erich", "M. Remarque", "n/a");
        a1.displayinfo();

        List<book> bklist = new List<book>();
        
        //book1
        book b0 = new book();
        b0.books("978-1-4193-6524-9", "Animal Farm", "author1");
        b0.books("", tdy);
        bklist.Add(b0);

        //book2
        book b1 = new book();
        b1.books("0449912477", "Flotsam", "author2");
        b1.books("", tdy);
        bklist.Add(b1);
        
        //book3
        book b2 = new book();
        b2.books("978-988-12356-0-2", "1984", "author1");
        b2.books("", tdy);
        bklist.Add(b2);

        //book4
        book b3 = new book();
        b3.books("9781604134025", "All Quiet on The Western Front.", "author2");
        b3.books("", tdy);
        bklist.Add(b3);

        //book5
        book b4 = new book();
        b4.books("015626224X", "Down and Out in Paris and London", "author1");
        b4.books("", tdy);
        bklist.Add(b4);

        //book6
        book b5 = new book();
        b5.books("	978-0-449-91251-5", "Spark of Life", "author2");
        b5.books("", tdy);
        bklist.Add(b5);

        foreach(book bk in bklist){
          Console.WriteLine("ISBN: {0}, TITLE: {1}, AUTHOR INFO: {2},\n PUBLISHER: {3}, DATE PUBLISHED: {4}", bk._ISBN, bk._TITLE, bk._authori, bk._publisher, bk._publishdate);
          Console.WriteLine();
        }

        Console.WriteLine("");
        Console.WriteLine("filtering books by authors");
        Console.WriteLine("");

        var sublisty = bklist.Where(book => book._authori == "author1");

        foreach(book s in sublisty){
          Console.WriteLine("ISBN: {0}, TITLE: {1}, AUTHOR INFO: {2}", s._ISBN, s._TITLE, s._authori);
        }

        Console.WriteLine("");

        var sublisty1 = bklist.Where(book => book._authori == "author2");

        foreach(book s1 in sublisty1){
          Console.WriteLine("ISBN: {0}, TITLE: {1}, AUTHOR INFO: {2}", s1._ISBN, s1._TITLE, s1._authori);
        }

        Console.WriteLine("");
        Console.WriteLine("removing the 'book1' from 'author1'");
        Console.WriteLine("");

        var sublisty2 = bklist.Where(book => book._authori == "author1");

        foreach(book s2 in sublisty2){
          if(s2._TITLE == "Animal Farm"){
            Console.WriteLine("");
          }else{
            Console.WriteLine("ISBN: {0}, TITLE: {1}, AUTHOR INFO: {2}", s2._ISBN, s2._TITLE, s2._authori);
          }
        }


    }
}
