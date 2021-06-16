using System;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("HI people!");
    Thread.Sleep(2000);
    Console.WriteLine("no-one likes to wait");
  }
}
